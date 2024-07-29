using GestaoProcessos.Aplicacao.Interfaces.Administracao;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace GestaoProcesso.Aplicacao.Administracao
{
    public class ApplicationServicePassword : IApplicationServicePassword
    {
        public string GerarSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }

        public string GerarHashPassword(string password, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: saltBytes,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }

        public bool VerificarPassword(string senha, string hash, string salt)
        {
            var hashVerificar = GerarHashPassword(senha, salt);
            return hashVerificar == hash;
        }
    }
}
