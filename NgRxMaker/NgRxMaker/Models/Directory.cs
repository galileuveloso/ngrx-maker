using System.Collections.Generic;
using System.Linq;

namespace NgRxMaker.Models
{
    public class Directory
    {
        public string Path { get; set; }
        public IList<File> Files { get; set; }
        public IList<Directory> Directories { get; set; }

        public void Create
        (
            string folder,
            string name,
            string entity,
            string feature
        )
        {
            string fullPath = GetFullPath(folder, name);

            System.IO.Directory.CreateDirectory(fullPath);

            foreach (File file in Files)
                System.IO.File.WriteAllText
                (
                    GetFilePath(fullPath, file, feature),
                    GetContent(file, entity, feature)
                ); ;

            if (HasDirectories())
                foreach (Directory directory in Directories)
                    directory
                        .Create
                        (
                            folder + "\\" + name,
                            Path,
                            entity,
                            feature
                        );
        }

        private string GetFullPath(string folder, string name)
            => System.IO.Path.Combine(folder, name + "\\" + Path);

        private string GetFilePath(string fullPath, File file, string feature)
            => fullPath + "\\" + file.Name.Replace("@feature", feature);

        private string GetContent(File file, string entity, string feature)
        {
            return
                file
                .Content
                    .Replace("@feature", feature)
                    .Replace("@entity", entity)
                    .Replace("@fEATURE", char.ToLower(entity[0]) + entity.Substring(1));
        }

        private bool HasDirectories()
            => Directories != null && Directories.Any();
    }
}
