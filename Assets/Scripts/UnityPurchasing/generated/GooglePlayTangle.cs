// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("DJRUTcwiN/le1UuFNru98A2WgArX65kbXeG6848TsmrYRtfJmvRY62O4yEOsHaDXkAjqq0exWhBnUVO6RI1EPaL/LeA9qBGWCWZV5EF6uFFqPoxJTSf/4vqAU9hFgo7EGyd4WfzcYx5IIWeGjxSqsok4++xNSXSU3tn+ftRu0ew5i4lJwVqQmmkFFZO37NZrX7OU9e5YYFeUUxRCyb1d2ZHnutaXJ6tLdSwqK9EH8FLWDps/Oo35j03OE/ZVjQjmYE+h7bkOufCcLq2OnKGqpYYq5Cpboa2tramsry6to6ycLq2mri6traxMxgU6jGijEAGXSY3FVSSN5Pw2NdJ6DGwrhh50XQhX4uHUp+v1lHK7VVLBSqK80JR5Lk+AuCBZNa6vrayt");
        private static int[] order = new int[] { 10,3,8,6,11,5,12,11,8,9,10,12,12,13,14 };
        private static int key = 172;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
