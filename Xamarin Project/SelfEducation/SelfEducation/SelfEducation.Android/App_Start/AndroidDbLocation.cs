using System;
using System.IO;
using SelfEducation.Business.Data.Contracts.Private;

namespace SelfEducation.Droid
{
    public class AndroidDbLocation : IDbLocation
    {
        private const string DataBaseName = "TaskDB.db3";

        public string DatabaseFilePath
        {
            get
            {
                var libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                return Path.Combine(libraryPath, DataBaseName);
            }
        }
    }
}