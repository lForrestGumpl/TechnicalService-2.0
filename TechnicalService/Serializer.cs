﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace TechnicalService
{
    internal class Serializer<T>
    {
        static BinaryFormatter binaryFormatter =
               new BinaryFormatter();
        string filePath;

        public Serializer(string filePath)
        {
            this.filePath = filePath;
        }

        public void Save(T objects, int autoincrement)
        {
            using (FileStream fs = new FileStream(
                filePath, FileMode.Create,
                FileAccess.Write))
            {
                fs.Write(BitConverter.GetBytes(
                    autoincrement), 0, 4);
                binaryFormatter.Serialize(fs, objects);
            }
        }

        public T Load(ref int autoincrement)
        {
            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                var type = typeof(T);
                var ctor = type.GetConstructor(Type.EmptyTypes);
                return (T)ctor.Invoke(null);
            }
            byte[] array = new byte[4];
            using (FileStream fs = new FileStream(
                filePath, FileMode.Open,
                FileAccess.Read))
            {
                fs.Read(array, 0, 4);
                autoincrement = BitConverter.
                    ToInt32(array, 0);
                return (T)binaryFormatter.
                    Deserialize(fs);
            }
        }
    }
}