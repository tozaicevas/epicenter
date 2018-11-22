﻿using System.IO;

namespace WebApplication1.Infrastructure.Utils
{
    public class ImageFromFileToBytes
    {
        public static byte[] GetImageFromFileAsByteArray(string imageFilePath)
        {
            using (FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }
        }
    }
}
