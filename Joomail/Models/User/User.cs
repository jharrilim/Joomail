using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace Joomail.Models.User
{
	internal abstract class User
	{
		private static readonly Rfc2898DeriveBytes rfc;

		public string Name { get; }

		private readonly byte[] _password;

		static User()
		{

		}

		public User(string name, char[] password)
		{
			Name = name;
			_password = Secure(password);
		}

		private static byte[] Secure (char[] pass)
		{
			// TODO: 
			string secret = Environment.GetEnvironmentVariable("userCryptoPassword");
			byte[] salt = new byte[8];
			using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
			{
				crypto.GetBytes(salt);
			}
			Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(pass.ToString(), salt);
			TripleDES tripleDES = TripleDES.Create();
			tripleDES.Key = key.GetBytes(16);
			CryptoStream encrypt = new CryptoStream
			(
				new MemoryStream(),
				tripleDES.CreateEncryptor(),
				CryptoStreamMode.Write
			);

			throw new NotImplementedException("WIP");
		}
    }
}
