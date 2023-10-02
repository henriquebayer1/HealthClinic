namespace Projeto.HealthClinic.Utils
{
    public static class Criptografia
    {

        public static string Criptografar(string senha)
        {

            return BCrypt.Net.BCrypt.HashString(senha);

        }

        public static bool CompararHash(string senhaForm, string senhaDB)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaDB);

        }

    }
}
