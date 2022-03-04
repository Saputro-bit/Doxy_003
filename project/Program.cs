using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Pseudocode
BEGIN
numeric jberas, jminyak, jtelur, jgula, jtepung, hberas, hminyak, htelur, hgula, htepung, pilih, total;
character lagi;

do
try
begin
	awal:
	Display "Toko Sembako";
	Display "-----------------------------";
	Display "1. Beras(11000/KG)";
	Display "2. Minyak(15000/Lt)";
	Display "3. Telur(20000/KG)";
	Display "4. Gula(12000/KG)";
	Display "5. Tepung(10000/KG)";
	Display "6. Exit";
	Display "Options (1/2/3/4/5/6) : ";   
	accept pilih
	switch(pilih)
	begin
		case 1 :
			begin
			display "Berapa KG yang mau di beli ? = "
			accept jberas
			hberas = jberas * 11000;
			total = total + hberas;
			display jberas + " KG beras sudah ditambahkan ke keranjang "
			break;
			end
			
		case 2 :
			begin
			display "Berapa KG yang mau di beli ? = "
			accept jminyak
			hminyak = jminyak * 15000;
			total = total + hminyak;
			display jminyak + " Lt minyak sudah ditambahkan ke keranjang "
			break;
			end

		case 3 : 
			begin
			display "Berapa KG yang mau di beli ? = "
			accept jtelur
			htelur = jtelur * 20000;
			total = total + htelur;
			display jtelur + " KG telur sudah ditambahkan ke keranjang "
			break;
			end

		case 4 :
			begin
			display "Berapa KG yang mau di beli ? = "
			accept jgula
			hgula = jgula * 12000;
			total = total + hgula;
			display jgula + " KG gula sudah ditambahkan ke keranjang "
			break;
			end
			
		case 5 :
			begin
			display "Berapa KG yang mau di beli ? = "
			accept jtepung
			htepung = jtepung * 20000;
			total = total + htepung;
			display jtepung + " KG tepung sudah ditambahkan ke keranjang "
			break;
			end
		
		case 6 :
			if (total==0)
			begin
				return;
			end
			else
			begin
				display "-----------------------------------"
				display "Nota : "
				display jberas+" KG beras"
				display jminyak+" Lt Minyak"
				display jtelur+" KG telur"
				display jgula+" KG gula"
				display jtepung+" KG Tepung"
				display "-----------------------------------"
				display "Ingin belanja lagi ?"
				accept lagi
				if (lagi == y)
				begin
					goto awal
				end
				else
				begin
					cetak nota;
					return;
				end
			end
			break;
		default display "Inputan Salah !!!"
		break;
		
	end
catch(formatexception)
begin
display "Masukkan Angka"
end
while (pilih != 6)
end
END 
*/

/// <summary>
/// menjelaskan jenis barang
/// </summary>
namespace project
{
    class Program
    {
        public double jberas, jminyak, jtelur, jgula, jtepung, hberas, hminyak, htelur, hgula, htepung;
        double total;
        int pilih;
        char lagi;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.menu();
        }

        /// <summary>
        /// menjelaskan nama barang
        /// </summary>
        public void menu()
        {
            do
            {
                try
                {
                awal:
                    Console.Clear();
                    Console.WriteLine("Toko Sembako");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("1. Beras (11000/KG)");
                    Console.WriteLine("2. Minyak (15000/Lt)");
                    Console.WriteLine("3. Telur (20000/KG)");
                    Console.WriteLine("4. Gula (12000/KG)");
                    Console.WriteLine("5. Tepung (10000/KG)");
                    Console.WriteLine("6. Exit");
                    Console.Write("Options (1/2/3/4/5/6) : ");
                    pilih = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-----------------------------");

                    switch (pilih)
                    {
                        case 1:
                            beras();
                            break;
                        case 2:
                            minyak();
                            break;
                        case 3:
                            telur();
                            break;
                        case 4:
                            gula();
                            break;
                        case 5:
                            tepung();
                            break;
                        case 6:
                            if (total == 0)
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine("----------------------");
                                Console.WriteLine("Keranjang : " +
                                    "\n {0} kg Beras" +
                                    "\n {1} lt Minyak" +
                                    "\n {2} kg Telur" +
                                    "\n {3} kg Gula" +
                                    "\n {4} kg Tepung" +
                                    "\n\n----------------------\n" +
                                    "Total = {5}", jberas, jminyak, jtelur, jgula, jtepung, total);
                                Console.WriteLine("----------------------\n");
                                Console.Write("Ingin Berbelanja Lagi ? [Y/T] = ");
                                lagi = Convert.ToChar(Console.ReadLine());
                                if ((lagi == 'y') || (lagi == 'Y'))
                                {
                                    goto awal;
                                }
                                else if ((lagi == 't') || (lagi == 'T'))
                                {
                                    nota();
                                    return;
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Inputan Salah !!!");
                            break;
                    }
                    Console.ReadKey();
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Mohon Masukkan Angka 1-6");
                }
            }
            while (pilih != 6) ;
           
        }

        /// <summary>
        /// menjelaskan total barang beras
        /// </summary>
        public void beras()
        {
            try
            {
                Console.Write("Berapa KG yang mau dibeli ? = ");
                jberas = Convert.ToDouble(Console.ReadLine());
                hberas = jberas * 11000;
                total = total + hberas;
                Console.WriteLine("{0} KG beras sudah ditambahkan ke keranjang", jberas);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Mohon Masukkan Angka");
            }
        }

        /// <summary>
        /// menjelaskan total barang minyak
        /// </summary>
        public void minyak()    
        {
            try
            {
                Console.Write("Berapa Liter yang mau dibeli ? = ");
                jminyak = Convert.ToDouble(Console.ReadLine());
                hminyak = jminyak * 15000;
                total = total + hminyak;
                Console.WriteLine("{0} Liter minyak sudah ditambahkan ke keranjang", jminyak);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Mohon Masukkan Angka");
            }
        }

        /// <summary>
        /// menjelaskan total barang telur
        /// </summary>
        public void telur()
        {
            try
            {
                Console.Write("Berapa KG yang mau dibeli ? = ");
                jtelur = Convert.ToDouble(Console.ReadLine());
                htelur = jtelur * 20000;
                total = total + htelur;
                Console.WriteLine("{0} KG telur sudah ditambahkan ke keranjang", jtelur);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Mohon Masukkan Angka");
            }
        }

        /// <summary>
        /// menjelaskan total barang gula
        /// </summary>
        public void gula()
        {
            try
            { 
                Console.Write("Berapa KG yang mau dibeli ? = ");
                jgula = Convert.ToDouble(Console.ReadLine());
                hgula = jgula * 12000;
                total = total + hgula;
                Console.WriteLine("{0} KG gula sudah ditambahkan ke keranjang", jgula);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Mohon Masukkan Angka");
            }
        }

        /// <summary>
        /// menjelaskan total barang tepung
        /// </summary>
        public void tepung()
        {
            try
            {
                Console.Write("Berapa KG yang mau dibeli ? = ");
                jtepung = Convert.ToDouble(Console.ReadLine());
                htepung = jtepung * 10000;
                total = total + htepung;
                Console.WriteLine("{0} KG tepung sudah ditambahkan ke keranjang", jtepung);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Mohon Masukkan Angka");
            }
        }

        /// <summary>
        /// menjelaskan nota
        /// </summary>
        public void nota()
        {
            try
            {         
                StreamWriter sw = new StreamWriter("D:\\Receipt.txt");
                sw.WriteLine("----------------------");
                sw.WriteLine("Nota : " +
                    "\n {0} kg Beras" +
                    "\n {1} lt Minyak" +
                    "\n {2} kg Telur" +
                    "\n {3} kg Gula" +
                    "\n {4} kg Tepung" +
                    "\n\n----------------------\n" +
                    "Total = {5}", jberas, jminyak, jtelur, jgula,jtepung, total);
                sw.WriteLine("----------------------\n");
                sw.Close(); 
            }        
            catch (Exception e)
            {         
                Console.WriteLine("Exception: " + e.Message);
            }        
            finally        
            {         
                Console.WriteLine("Executing finally block."); 
            }
        }
    }
}
