using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envanter_Takip
{
    class DEScrypt
    {
        ArrayList initial_Permutation=new ArrayList();
        ArrayList pc1 = new ArrayList();
        String pc2 ="";
        String key="KRiPGefO";
        
        
        String[,] s1 = { {"1110", "0100", "1101", "0001", "0010", "1111", "1011", "1000", "0011", "1010", "0110", "1100", "0101", "1001", "0000", "0111" },
                         {"0000", "1111", "0111", "0010", "1110", "0010", "1101", "0001", "1010", "0110", "1100", "1011", "1001", "0101", "0011", "1000" },
                         {"0100", "0001", "1110", "1000", "1101", "0110", "0010", "1011", "1111", "1100", "1001", "0111", "0011", "1010", "0101", "0000" },
                         {"1111", "1100", "1000", "0010", "0100", "1001", "0001", "0111", "0101", "1011", "0011", "1110", "1010", "0000", "0110", "1101" }};
        String[,] s2 = { {"1111", "0001", "1000", "1110", "0110", "1011", "0011", "0100", "1001", "0111", "0010", "1101", "1100", "0000", "0101", "1010" },
                         {"0011", "1101", "0100", "0111", "1111", "0010", "1000", "1100", "1100", "0000", "0001", "1010", "0110", "1001", "1011", "0101" },
                         {"0000", "1110", "0111", "1011", "1010", "0100", "1101", "0001", "0101", "1000", "1100", "0110", "1001", "0011", "0010", "1111" },
                         {"1111", "1100", "1000", "0010", "0100", "1001", "0001", "0111", "0101", "1011", "0011", "1110", "1010", "0000", "0110", "1101" }};
        String[,] s3 = { {"1010", "0000", "1001", "1110", "0110", "0011", "1111", "0101", "0001", "1101", "1100", "0111", "1011", "0100", "0010", "1000" },
                         {"0000", "1111", "0111", "0010", "1110", "0010", "1101", "0001", "1010", "0110", "1100", "1011", "1001", "0101", "0011", "1000" },
                         {"1101", "0110", "0100", "1001", "1000", "1111", "0011", "0000", "1011", "0001", "0010", "1100", "0101", "1010", "1110", "0111" },
                         {"0001", "1010", "1101", "0000", "0110", "1001", "1000", "0111", "0100", "1111", "1100", "0011", "1011", "0101", "0010", "1100" }};
        String[,] s4={ {"1010", "0000", "1001", "1110", "0110", "0011", "1111", "0101", "0001", "1101", "1100", "0111", "1011", "0100", "0010", "1000" },
                       {"0000", "1111", "0111", "0010", "1110", "0010", "1101", "0001", "1010", "0110", "1100", "1011", "1001", "0101", "0011", "1000" },
                       {"1101", "0110", "0100", "1001", "1000", "1111", "0011", "0000", "1011", "0001", "0010", "1100", "0101", "1010", "1110", "0111" },
                       {"0001", "1010", "1101", "0000", "0110", "1001", "1000", "0111", "0100", "1111", "1100", "0011", "1011", "0101", "0010", "1100" }};
        String[,] s5={ {"1111", "0001", "1000", "1110", "0110", "1011", "0011", "0100", "1001", "0111", "0010", "1101", "1100", "0000", "0101", "1010" },
                         {"0011", "1101", "0100", "0111", "1111", "0010", "1000", "1100", "1100", "0000", "0001", "1010", "0110", "1001", "1011", "0101" },
                         {"0000", "1110", "0111", "1011", "1010", "0100", "1101", "0001", "0101", "1000", "1100", "0110", "1001", "0011", "0010", "1111" },
                         {"1111", "1100", "1000", "0010", "0100", "1001", "0001", "0111", "0101", "1011", "0011", "1110", "1010", "0000", "0110", "1101" }};
        String[,] s6={ {"1110", "0100", "1101", "0001", "0010", "1111", "1011", "1000", "0011", "1010", "0110", "1100", "0101", "1001", "0000", "0111" },
                         {"0000", "1111", "0111", "0010", "1110", "0010", "1101", "0001", "1010", "0110", "1100", "1011", "1001", "0101", "0011", "1000" },
                         {"0100", "0001", "1110", "1000", "1101", "0110", "0010", "1011", "1111", "1100", "1001", "0111", "0011", "1010", "0101", "0000" },
                         {"1111", "1100", "1000", "0010", "0100", "1001", "0001", "0111", "0101", "1011", "0011", "1110", "1010", "0000", "0110", "1101" }};
        String[,] s7={ {"1010", "0000", "1001", "1110", "0110", "0011", "1111", "0101", "0001", "1101", "1100", "0111", "1011", "0100", "0010", "1000" },
                         {"0000", "1111", "0111", "0010", "1110", "0010", "1101", "0001", "1010", "0110", "1100", "1011", "1001", "0101", "0011", "1000" },
                         {"1101", "0110", "0100", "1001", "1000", "1111", "0011", "0000", "1011", "0001", "0010", "1100", "0101", "1010", "1110", "0111" },
                         {"0001", "1010", "1101", "0000", "0110", "1001", "1000", "0111", "0100", "1111", "1100", "0011", "1011", "0101", "0010", "1100" }};
        String[,] s8={ {"1010", "0000", "1001", "1110", "0110", "0011", "1111", "0101", "0001", "1101", "1100", "0111", "1011", "0100", "0010", "1000" },
                       {"0000", "1111", "0111", "0010", "1110", "0010", "1101", "0001", "1010", "0110", "1100", "1011", "1001", "0101", "0011", "1000" },
                       {"1101", "0110", "0100", "1001", "1000", "1111", "0011", "0000", "1011", "0001", "0010", "1100", "0101", "1010", "1110", "0111" },
                       {"0001", "1010", "1101", "0000", "0110", "1001", "1000", "0111", "0100", "1111", "1100", "0011", "1011", "0101", "0010", "1100" }};


        public DEScrypt() { }

        public static byte[] ConvertToByteArray(string str, Encoding encoding)
        {
            
            return encoding.GetBytes(str);
        }

        public static String ToBinary(Byte[] data)
        {
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }

        //Stringi binary halne dönüştürme.
        private String BinaryDonustur(String sifre) {
            var binaryString = ToBinary(ConvertToByteArray(sifre, Encoding.Unicode));
            return binaryString;
        }
        
        //Binary olan şifreyi IP tablosuna yerleştirme metodu.
        private void InitialPermOlustur(String binarysifre)
        {
            
            
            initial_Permutation.Add(binarysifre.ElementAt(57));
            initial_Permutation.Add(binarysifre.ElementAt(49));
            initial_Permutation.Add(binarysifre.ElementAt(41));
            initial_Permutation.Add(binarysifre.ElementAt(33));
            initial_Permutation.Add(binarysifre.ElementAt(25));
            initial_Permutation.Add(binarysifre.ElementAt(17));
            initial_Permutation.Add(binarysifre.ElementAt(9));
            initial_Permutation.Add(binarysifre.ElementAt(1));
            initial_Permutation.Add(binarysifre.ElementAt(59));
            initial_Permutation.Add(binarysifre.ElementAt(51));
            initial_Permutation.Add(binarysifre.ElementAt(43));
            initial_Permutation.Add(binarysifre.ElementAt(35));
            initial_Permutation.Add(binarysifre.ElementAt(27));
            initial_Permutation.Add(binarysifre.ElementAt(19));
            initial_Permutation.Add(binarysifre.ElementAt(11));
            initial_Permutation.Add(binarysifre.ElementAt(3));
            initial_Permutation.Add(binarysifre.ElementAt(61));
            initial_Permutation.Add(binarysifre.ElementAt(53));
            initial_Permutation.Add(binarysifre.ElementAt(45));
            initial_Permutation.Add(binarysifre.ElementAt(37));
            initial_Permutation.Add(binarysifre.ElementAt(29));
            initial_Permutation.Add(binarysifre.ElementAt(21));
            initial_Permutation.Add(binarysifre.ElementAt(13));
            initial_Permutation.Add(binarysifre.ElementAt(5));
            initial_Permutation.Add(binarysifre.ElementAt(63));
            initial_Permutation.Add(binarysifre.ElementAt(55));
            initial_Permutation.Add(binarysifre.ElementAt(47));
            initial_Permutation.Add(binarysifre.ElementAt(39));
            initial_Permutation.Add(binarysifre.ElementAt(31));
            initial_Permutation.Add(binarysifre.ElementAt(23));
            initial_Permutation.Add(binarysifre.ElementAt(15));
            initial_Permutation.Add(binarysifre.ElementAt(7));
            initial_Permutation.Add(binarysifre.ElementAt(56));
            initial_Permutation.Add(binarysifre.ElementAt(48));
            initial_Permutation.Add(binarysifre.ElementAt(40));
            initial_Permutation.Add(binarysifre.ElementAt(32));
            initial_Permutation.Add(binarysifre.ElementAt(24));
            initial_Permutation.Add(binarysifre.ElementAt(16));
            initial_Permutation.Add(binarysifre.ElementAt(8));
            initial_Permutation.Add(binarysifre.ElementAt(0));
            initial_Permutation.Add(binarysifre.ElementAt(58));
            initial_Permutation.Add(binarysifre.ElementAt(50));
            initial_Permutation.Add(binarysifre.ElementAt(42));
            initial_Permutation.Add(binarysifre.ElementAt(34));
            initial_Permutation.Add(binarysifre.ElementAt(26));
            initial_Permutation.Add(binarysifre.ElementAt(18));
            initial_Permutation.Add(binarysifre.ElementAt(10));
            initial_Permutation.Add(binarysifre.ElementAt(2));
            initial_Permutation.Add(binarysifre.ElementAt(60));
            initial_Permutation.Add(binarysifre.ElementAt(52));
            initial_Permutation.Add(binarysifre.ElementAt(44));
            initial_Permutation.Add(binarysifre.ElementAt(36));
            initial_Permutation.Add(binarysifre.ElementAt(28));
            initial_Permutation.Add(binarysifre.ElementAt(20));
            initial_Permutation.Add(binarysifre.ElementAt(12));
            initial_Permutation.Add(binarysifre.ElementAt(4));
            initial_Permutation.Add(binarysifre.ElementAt(62));
            initial_Permutation.Add(binarysifre.ElementAt(54));
            initial_Permutation.Add(binarysifre.ElementAt(46));
            initial_Permutation.Add(binarysifre.ElementAt(38));
            initial_Permutation.Add(binarysifre.ElementAt(30));
            initial_Permutation.Add(binarysifre.ElementAt(22));
            initial_Permutation.Add(binarysifre.ElementAt(14));
            initial_Permutation.Add(binarysifre.ElementAt(6));
         
        }

        //Keyi binary yaptık ve PC-1 tablosuna yerleştirdik.
        private void Pc1Donustur() {
            String binaryKey = BinaryDonustur(key);
            pc1.Add(binaryKey.ElementAt(56));
            pc1.Add(binaryKey.ElementAt(48));
            pc1.Add(binaryKey.ElementAt(40));
            pc1.Add(binaryKey.ElementAt(32));
            pc1.Add(binaryKey.ElementAt(24));
            pc1.Add(binaryKey.ElementAt(16));
            pc1.Add(binaryKey.ElementAt(8));
            pc1.Add(binaryKey.ElementAt(0));
            pc1.Add(binaryKey.ElementAt(57));
            pc1.Add(binaryKey.ElementAt(49));
            pc1.Add(binaryKey.ElementAt(41));
            pc1.Add(binaryKey.ElementAt(33));
            pc1.Add(binaryKey.ElementAt(25));
            pc1.Add(binaryKey.ElementAt(17));
            pc1.Add(binaryKey.ElementAt(9));
            pc1.Add(binaryKey.ElementAt(1));
            pc1.Add(binaryKey.ElementAt(58));
            pc1.Add(binaryKey.ElementAt(50));
            pc1.Add(binaryKey.ElementAt(42));
            pc1.Add(binaryKey.ElementAt(34));
            pc1.Add(binaryKey.ElementAt(26));
            pc1.Add(binaryKey.ElementAt(18));
            pc1.Add(binaryKey.ElementAt(10));
            pc1.Add(binaryKey.ElementAt(2));
            pc1.Add(binaryKey.ElementAt(59));
            pc1.Add(binaryKey.ElementAt(51));
            pc1.Add(binaryKey.ElementAt(43));
            pc1.Add(binaryKey.ElementAt(35));
            pc1.Add(binaryKey.ElementAt(62));
            pc1.Add(binaryKey.ElementAt(54));
            pc1.Add(binaryKey.ElementAt(46));
            pc1.Add(binaryKey.ElementAt(38));
            pc1.Add(binaryKey.ElementAt(30));
            pc1.Add(binaryKey.ElementAt(22));
            pc1.Add(binaryKey.ElementAt(14));
            pc1.Add(binaryKey.ElementAt(6));
            pc1.Add(binaryKey.ElementAt(61));
            pc1.Add(binaryKey.ElementAt(53));
            pc1.Add(binaryKey.ElementAt(45));
            pc1.Add(binaryKey.ElementAt(37));
            pc1.Add(binaryKey.ElementAt(29));
            pc1.Add(binaryKey.ElementAt(21));
            pc1.Add(binaryKey.ElementAt(13));
            pc1.Add(binaryKey.ElementAt(5));
            pc1.Add(binaryKey.ElementAt(60));
            pc1.Add(binaryKey.ElementAt(52));
            pc1.Add(binaryKey.ElementAt(44));
            pc1.Add(binaryKey.ElementAt(36));
            pc1.Add(binaryKey.ElementAt(28));
            pc1.Add(binaryKey.ElementAt(20));
            pc1.Add(binaryKey.ElementAt(12));
            pc1.Add(binaryKey.ElementAt(4));
            pc1.Add(binaryKey.ElementAt(27));
            pc1.Add(binaryKey.ElementAt(19));
            pc1.Add(binaryKey.ElementAt(11));
            pc1.Add(binaryKey.ElementAt(3));
            
        }

        private String Pc2Donustur(ArrayList array)
        {
            pc2+=array[13];
            pc2+=array[16];
            pc2+=array[10];
            pc2+=array[23];
            pc2+=array[0];
            pc2+=array[4];
            pc2+=array[2];
            pc2+=array[27];
            pc2+=array[14];
            pc2+=array[5];
            pc2+=array[20];
            pc2+=array[9];
            pc2+=array[22];
            pc2+=array[18];
            pc2+=array[11];
            pc2+=array[3];
            pc2+=array[25];
            pc2+=array[7];
            pc2+=array[15];
            pc2+=array[6];
            pc2+=array[26];
            pc2+=array[19];
            pc2+=array[12];
            pc2+=array[1];
            pc2+=array[40];
            pc2+=array[51];
            pc2+=array[30];
            pc2+=array[36];
            pc2+=array[46];
            pc2+=array[54];
            pc2+=array[29];
            pc2+=array[39];
            pc2+=array[50];
            pc2+=array[44];
            pc2+=array[32];
            pc2+=array[47];
            pc2+=array[43];
            pc2+=array[48];
            pc2+=array[38];
            pc2+=array[55];           
            pc2+=array[33];
            pc2+=array[52];
            pc2+=array[45];
            pc2+=array[41];
            pc2+=array[49];
            pc2+=array[35];
            pc2+=array[28];
            pc2+=array[31];
            return pc2;
        }

        private ArrayList LeftRotateArray(ArrayList array, int dondurmeSayisi)
        {            
            for (int i = 0; i < dondurmeSayisi; i++)
            {
                array.Add(array[i]);
            }
            for (int i = 0; i < dondurmeSayisi; i++)
            {
                array.RemoveAt(0);
            }
            return array;
        }

        //1,2,9 ve 16. key iterasyonlarında bu fonksiyon
        private String BirKeyDongusu1Rot(ArrayList c,ArrayList d)
        {
            ArrayList c1 = LeftRotateArray(c, 1);
            ArrayList d1 = LeftRotateArray(d, 1);
            for (int i = 0; i < d.Count; i++)
            {
                c1.Add(d[i]);
            }
            return (Pc2Donustur(c1));
        }
        //Kalan key iterasyon adımlarında kullanılacak
        private String BirKeyDongusu2rot(ArrayList c, ArrayList d)
        {
            ArrayList c1 = LeftRotateArray(c, 2);
            ArrayList d1 = LeftRotateArray(d, 2);
            for (int i = 0; i < d.Count; i++)
            {
                c1.Add(d[i]);
            }
            return (Pc2Donustur(c1));
        }
        //DÖNGÜYE BAŞLARKEN PC-1 YAPMAYI UNUTMA PLSSS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        
        private void Fonksiyon(ArrayList array,String key)
        {
            String expansion = "";
            expansion += array[31];
            expansion += array[0];
            expansion += array[1];
            expansion += array[2];
            expansion += array[3];
            expansion += array[4];
            expansion += array[5];
            expansion += array[4];
            expansion += array[5];
            expansion += array[6];
            expansion += array[7];
            expansion += array[8];
            expansion += array[9];
            expansion += array[8];
            expansion += array[9];
            expansion += array[10];
            expansion += array[11];
            expansion += array[12];
            expansion += array[13];
            expansion += array[12];
            expansion += array[13];
            expansion += array[14];
            expansion += array[15];
            expansion += array[16];
            expansion += array[17];
            expansion += array[16];
            expansion += array[17];
            expansion += array[18];
            expansion += array[19];
            expansion += array[20];
            expansion += array[21];
            expansion += array[20];
            expansion += array[21];
            expansion += array[22];
            expansion += array[23];
            expansion += array[24];
            expansion += array[25];
            expansion += array[24];
            expansion += array[25];
            expansion += array[26];
            expansion += array[27];
            expansion += array[28];
            expansion += array[29];
            expansion += array[28];
            expansion += array[29];
            expansion += array[30];
            expansion += array[31];
            expansion += array[32];
            expansion += array[0];

            uint x = uint.Parse(expansion) ^ uint.Parse(key);

        }

        private void SKutulari(String bit6,int[,] skutusu) {
            String raw = bit6[0].ToString()+bit6[5].ToString();
            String collumn = bit6[1].ToString() + bit6[2].ToString() + bit6[3].ToString() + bit6[4].ToString();

            return skutusu[raw,collumn]; //ikilik tabanda bunlar inte dönüştür
        }
    }
}
