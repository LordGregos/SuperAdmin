using System;
using System.Security.Cryptography;

namespace Shared
{
    public class Cifrado
    {
        private static int minLargo = 8;
        private static int maxLargo = 10;

        private static string minusculas = "abcdefgijkmnopqrstwxyz";
        private static string mayusculas = "ABCDEFGHJKLMNPQRSTWXYZ";
        private static string numeros = "23456789";
        private static string mayusculas2 = "ABCDEFGHJKLMNPQRSTWXYZ";

        public static string CreateSHAHash(string Password, string Salt)
        {
            System.Security.Cryptography.SHA512Managed HashTool = new System.Security.Cryptography.SHA512Managed();
            Byte[] PasswordAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Password, Salt));
            Byte[] EncryptedBytes = HashTool.ComputeHash(PasswordAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }

        public static string Generate()
        {
            return Generate(minLargo,
                            maxLargo);
        }

        public static string Generate(int length)
        {
            return Generate(length, length);
        }

        public static string Generate(int minLength,
                                      int maxLength)
        {
            if (minLength <= 0 || maxLength <= 0 || minLength > maxLength)
                return null;

            char[][] charGroups = new char[][]
            {
            minusculas.ToCharArray(),
            mayusculas.ToCharArray(),
            numeros.ToCharArray(),
            mayusculas2.ToCharArray()
            };

            int[] charsLeftInGroup = new int[charGroups.Length];

            for (int i = 0; i < charsLeftInGroup.Length; i++)
                charsLeftInGroup[i] = charGroups[i].Length;

            int[] leftGroupsOrder = new int[charGroups.Length];

            for (int i = 0; i < leftGroupsOrder.Length; i++)
                leftGroupsOrder[i] = i;

            byte[] randomBytes = new byte[4];

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);

            int seed = BitConverter.ToInt32(randomBytes, 0);

            Random random = new Random(seed);

            char[] password = null;

            if (minLength < maxLength)
                password = new char[random.Next(minLength, maxLength + 1)];
            else
                password = new char[minLength];

            int sigLetra;

            int sigGrupo;

            int sigGrupoOrden;

            int ultimaLetra;

            int lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;

            for (int i = 0; i < password.Length; i++)
            {
                if (lastLeftGroupsOrderIdx == 0)
                    sigGrupoOrden = 0;
                else
                    sigGrupoOrden = random.Next(0,
                                                         lastLeftGroupsOrderIdx);

                sigGrupo = leftGroupsOrder[sigGrupoOrden];

                ultimaLetra = charsLeftInGroup[sigGrupo] - 1;

                if (ultimaLetra == 0)
                    sigLetra = 0;
                else
                    sigLetra = random.Next(0, ultimaLetra + 1);

                password[i] = charGroups[sigGrupo][sigLetra];

                if (ultimaLetra == 0)
                    charsLeftInGroup[sigGrupo] =
                                              charGroups[sigGrupo].Length;
                else
                {
                    if (ultimaLetra != sigLetra)
                    {
                        char temp = charGroups[sigGrupo][ultimaLetra];
                        charGroups[sigGrupo][ultimaLetra] =
                                    charGroups[sigGrupo][sigLetra];
                        charGroups[sigGrupo][sigLetra] = temp;
                    }
                    charsLeftInGroup[sigGrupo]--;
                }

                if (lastLeftGroupsOrderIdx == 0)
                    lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;
                else
                {
                    if (lastLeftGroupsOrderIdx != sigGrupoOrden)
                    {
                        int temp = leftGroupsOrder[lastLeftGroupsOrderIdx];
                        leftGroupsOrder[lastLeftGroupsOrderIdx] =
                                    leftGroupsOrder[sigGrupoOrden];
                        leftGroupsOrder[sigGrupoOrden] = temp;
                    }
                    lastLeftGroupsOrderIdx--;
                }
            }

            return new string(password);
        }

    }
}
