using System;
using System.Collections.Generic;
using System.Text;

namespace Support
{
    public class GPS
    {
        public delegate void UpdateGps(DateTime Time, double Latitude, double Longitude, double Speed, double Altitude);
        static public event UpdateGps GpsUpdateEvent;
        static public void ChangePosition(DateTime Time, double Latitude, double Longitude, double Speed, double Altitude)
        {
            UpdateGps handler = GpsUpdateEvent;
            if (handler != null)
            {
                handler(Time, Latitude, Longitude, Speed, Altitude);
            }
        }
    }

    public class TTS
    {
        public static SpeakFunction Speack;
        public delegate void SpeakFunction(string text);
    }

    public class DeviceManager
    {
        public static LockOrientation LockDislplayOrientation;
        public delegate void LockOrientation(bool SetValue);
    }

    public class Clipboard
    {
        public static CopyToClipboard Copy;
        public delegate void CopyToClipboard(string Text);

        public static PasteFromClipboard Paste;
        public delegate string PasteFromClipboard();
    }

    public class StorageManager
    {
        public static string SaveObject(object Obj, string Key)
        {
            Key = KeyToNameFile(Key);
            string Extension = null;
            Extension = ".xml";

            string SubDir = Obj.GetType().FullName;
            if (SubDir.Contains("Version="))
            {
                SubDir = Obj.GetType().Namespace + "+" + Obj.GetType().Name;
            }
            //SubDir = System.IO.Directory.GetCurrentDirectory() + @"/" + SubDir;
            SubDir = Path() + SubDir;

            if (Key.Length > 255)
            {
                throw new System.ArgumentException("File name too long", "");
                //Microsoft.VisualBasic.Err.Raise(65535, Nothing, "File name too long")
            }
            else
            {
                Serialize(Obj, SubDir + "." + Key + Extension);
            }

            return Key;
        }

        public static object LoadObject(Type Type, string Key)
        {
            //NOTE: Use GetType command to set Type value; Ex,: LoadObject(x,GetType(Note),key)
            object Obj = null;
            Key = KeyToNameFile(Key);
            string Extension = null;
            Extension = ".xml";
            string SubDir = Type.FullName;
            if (SubDir.Contains("Version="))
            {
                SubDir = Type.Namespace + "+" + Type.Name;
            }
            SubDir = Path() + SubDir;
            try
            {
                Obj = Deserialize(SubDir + "." + Key + Extension, Type);
            }
            catch (Exception ex)
            {
            }
            return Obj;
        }

        public static void DeleteObject(Type Type, string Key)
        {
            Key = KeyToNameFile(Key);
            string Extension = null;
            Extension = ".xml";
            string SubDir = Type.FullName;
            if (SubDir.Contains("Version="))
            {
                SubDir = Type.Namespace + "+" + Type.Name;
            }
            SubDir = Path() + SubDir;
            string NameFile = SubDir + "." + Key + Extension;

        }

        private static string KeyToNameFile(string Text, string HexMark = "%")
        {
            string functionReturnValue = null;
            functionReturnValue = null;
            if (!string.IsNullOrEmpty(Text))
            {
                foreach (char Chr in Text.ToCharArray())
                {
                    switch (Chr)
                    {
                        case ':':
                        case '*':
                        case '?':
                        case '/':
                        case '\\':
                        case '|':
                        case '<':
                        case '>':
                        case '"':
                            // KeyToNameFile &= HexMark & Microsoft.VisualBasic.Right("00" & Hex(Asc(Chr)), 2)
                            functionReturnValue += "-";
                            break;
                        default:
                            functionReturnValue += Chr;
                            break;
                    }
                }
            }
            return functionReturnValue;
        }

        public static void Serialize(object Obj, string NameFile)
        {
            string KeyLock = NameFile.ToLower();
            //Exception Er = null;
            try
            {
                int NTry = 0;
                int NTryError = 0;
                do
                {

                    NTry = NTryError;
                    System.IO.StreamWriter Stream = new System.IO.StreamWriter(NameFile);// FileManager.WriteFileStream(NameFile);
                    try
                    {
                        System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(Obj.GetType());
                        xml.Serialize(Stream, Obj);
                    }
                    catch (Exception ex)
                    {
                        NTryError += 1;
                        //Sleep(500);
                    }
                    finally
                    {
                        if (Stream != null)
                        {
                            Stream.Dispose();
                        }
                    }
                } while (!(NTry == NTryError || NTryError > (5000 / 500)));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static object Deserialize(string NameFile, Type Type = null)
        {
            //Parameter "Type" is need for XML deserialization
            object Obj = null;

            //Dim Storage As IO.IsolatedStorage.IsolatedStorageFile = IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication()

            if (System.IO.File.Exists(NameFile))
            {
                string KeyLock = NameFile.ToLower();
                Exception Er = default(Exception);
                try
                {
                    int NTry = 0;
                    int NTryError = 0;
                    do
                    {
                        NTry = NTryError;
                        //Dim Stream As New IO.IsolatedStorage.IsolatedStorageFileStream(NameFile, System.IO.FileMode.Open, System.IO.FileAccess.Read, IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication)
                        System.IO.StreamReader Stream = new System.IO.StreamReader(NameFile); // FileManager.ReadFileStream(NameFile);
                        try
                        {
                            System.Xml.Serialization.XmlSerializer XML = new System.Xml.Serialization.XmlSerializer(Type);

                            Obj = XML.Deserialize(Stream);
                            Er = null;
                        }
                        catch (Exception ex)
                        {
                            Er = ex;
                            NTryError += 1;
                            //Sleep(500);
                        }
                        finally
                        {
                            if (Stream != null)
                            {
                                Stream.Dispose();
                            }
                        }
                    } while (!(NTry == NTryError || NTryError > (5000 / 500)));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Obj;
        }

        public static string Path()
        {
#if __ANDROID__
            return Android.OS.Environment.ExternalStorageDirectory.AbsolutePath + @"/";
#else
            return "";
#endif
        }

    }

    public class JsonManager
    {
        public static Dictionary<String, String> JesonToKeyValue(string Json)
        {
            Dictionary<String, String> Collect = new Dictionary<String, String>();
            string[] Elements = Json.Split(new Char[] { ',' });
            foreach (string Element in Elements)
            {
                string[] Parts = Element.Split(new Char[] { '"' });
                Collect.Add(Parts[1], Parts[3]);
            }
            return Collect;
        }
    }
    //public class FileManager
    //{
    //    public static FileExistsFunction FileExists;
    //    public delegate bool FileExistsFunction(string NameFile);

    //    public static DeleteFileFunction DeleteFile;
    //    public delegate void DeleteFileFunction(string NameFile);

    //    public static WriteFileStreamFunction WriteFileStream;
    //    public delegate System.IO.StreamWriter WriteFileStreamFunction(string NameFile);

    //    public static ReadFileStreamFunction ReadFileStream;
    //    public delegate System.IO.StreamReader ReadFileStreamFunction(string NameFile);

    //    public static void WriteFile(string NameFile, string Data)
    //    {
    //        var Writer = WriteFileStream(NameFile);
    //        Writer.Write(Data);
    //        Writer.Dispose();
    //    }

    //    public static string ReadFile(string NameFile)
    //    {
    //        var Reader = ReadFileStream(NameFile);
    //        string Data = Reader.ReadToEnd();
    //        Reader.Dispose();
    //        return Data;
    //    }
    //}
}
