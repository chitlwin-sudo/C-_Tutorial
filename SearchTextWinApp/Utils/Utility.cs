using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTextWinApp.Utils
{
    internal class Utility
    {

        public static List<string> GetAllFilesInDir(string dir)
        {
            try
            {
                List<string> fileList = Directory.GetFiles(dir, "*.txt", SearchOption.TopDirectoryOnly).ToList();

                return fileList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<string> GetAllDir(string dir, List<string> outputDirList)
        {
            List<string> dirs = new List<string>();

            try
            {
                dirs = Directory.GetDirectories(dir, "*", SearchOption.TopDirectoryOnly).ToList();

                foreach (string d in dirs)
                {
                    try
                    {
                        List<string> subSubDir = Directory.GetDirectories(d, "*", SearchOption.TopDirectoryOnly).ToList();

                        if (subSubDir.Count > 0)
                        {
                            foreach (string ssDir in subSubDir)
                            {
                                try
                                {
                                    List<string> ssDirList = GetAllDir(ssDir, outputDirList);

                                    if (ssDirList.Count > 0)
                                    {
                                        outputDirList.AddRange(ssDirList);
                                    }
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                        }
                        else
                        {
                            outputDirList.Add(d);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }


            }
            catch (Exception ex)
            {
                // Dir not found
                // Dir denided exception
            }

            return dirs;

        }
    }
}
