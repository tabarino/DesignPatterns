using System;

namespace DecoratorPattern
{
    public class Demo
    {
        public static void Show()
        {
            StoreCreditCard(new CloudStream());
            StoreCreditCard(new EncryptedCloudStream(new CloudStream()));
            StoreCreditCard(new EncryptedCloudStream(new CompressedCloudStream(new CloudStream())));
        }

        public static void StoreCreditCard(Stream stream)
        {
            stream.Write("1234-1234-1234-1234");
        }
    }
}
