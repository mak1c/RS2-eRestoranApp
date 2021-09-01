﻿using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;
        public KorisniciService(eRestoranContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Korisnici Authenticiraj(string username, string pass)
        {

            var user = _context.Korisnici.FirstOrDefault(x => x.KorisnickoIme == username);
         
            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
            }
            return null;

        }
       
        public static string GenerateSalt()
        { 
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }


        public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.Include(x=>x.Uloga).AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }
            if (!string.IsNullOrWhiteSpace(request?.BrojTelefona))
            {
                query = query.Where(x => x.Telefon.StartsWith(request.BrojTelefona));
            }
            if (request.StatusPretraga)
            {
                if (request.Status)
                {
                    query = query.Where(x => x.Status == true);
                }
                else
                {
                    query = query.Where(x => x.Status == false);
                }
            }
               
            if (!string.IsNullOrWhiteSpace(request?.Email))
            {
                query = query.Where(x => x.Email.StartsWith(request.Email));
            }
            if (!string.IsNullOrWhiteSpace(request?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme.StartsWith(request.KorisnickoIme));
            }
            if (request.UlogaId !=0)
            {
                query = query.Where(x => x.UlogaId==request.UlogaId);
            }
           

            var list = query.ToList();

            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);

            return _mapper.Map<Model.Korisnici>(entity);
        }
   
        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            entity.UlogaId = request.UlogaId;
            if (request.UlogaId!=0)
            {
                entity.UlogaId = request.UlogaId;
            }
            else
            {
                entity.UlogaId = 3;
            }
            _context.Korisnici.Add(entity);
            _context.SaveChanges();


           
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Update(int id, KorisniciUpdateRequest request)
        {
            var entity = _context.Korisnici.Find(id);
            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }
    }
}

