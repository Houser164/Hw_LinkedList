// G ดอกบานไม่รู้โรยจะเรียงติดต่อกันได้ไม่เกิน 3 ดอก Length G < 4 ไม่เป็นจริง “Invalid pattern.”

// J มะลิ

// O กล้วยไม้

// R ดอกกุหลาบจะต้องอยู่ระหว่าง ดอกไม้ 2 ชนิดที่แตกต่างกัน

//ต้องพิจารณาดอกไม้ข้างเคียงจากปลายอีกฝั่งของมาลัย
class Program
{
    static void Main(string[] args)
    {
         CircularLinkedList<char> FP = new CircularLinkedList<char>(); 

        while (true)
        {
            Console.WriteLine("Input your flower (J/G/O/R)");
            char SelectFlower = char.Parse(Console.ReadLine());

            if (SelectFlower != 'J' && SelectFlower != 'G' && SelectFlower != 'O' && SelectFlower != 'R' )
            {
                break;
            }

            else 
            {
                int FK = FP.GetLength(); 
                if (SelectFlower == 'R') // Loop R
                {
                    if (SelectFlower == 'R' && FK == 0) // ตัวแรกห้ามเป็น R
                    {
                        Console.WriteLine("Invalid pattern.");
                    }
                    else if (SelectFlower == 'R' && FK > 1) 
                    {
                        if (FP.Get(-1) == 'R' && FP.Get(-2) == 'R' ) // ถ้าด้านหน้าเป็น R และ 2 ตัวหน้าเป็น R จะเป็น R ไม่ได้ 
                        {
                            Console.WriteLine("Invalid pattern.");
                        }
                        else
                    {
                        FP.Add(SelectFlower);
                    }
                    }
                    else
                    {
                        FP.Add(SelectFlower);
                    }
                }

                if (SelectFlower == 'G') // Loop G
                {
                    if(FK == 0){
                        FP.Add(SelectFlower);  
                    }
                    else if (FK <= 2)
                    {
                        if (FP.Get(-1) == 'R' && FP.Get(-2) == 'G' ) // ถ้าด้านหน้าเป็น R และ 2 ตัวหน้าเป็น G จะเป็น G ไม่ได้ Indexน้อยกว่าเท่ากับ 2
                        {
                            Console.WriteLine("Invalid pattern.");
                        }
                        else{
                            FP.Add(SelectFlower);  
                        }  
                    }
                    else if (FK >= 3) 
                    {
                        if (FP.Get(-1) == 'R' && FP.Get(-2) == 'G' ) // ถ้าด้านหน้าเป็น R และ 2 ตัวหน้าเป็น G จะเป็น G ไม่ได้  Indexมากกว่าเท่ากับ 3
                        {
                            Console.WriteLine("Invalid pattern.");
                        }
                        else if (FP.Get(0) == 'G' && FP.Get(1) == 'G' && FP.Get(2) == 'G') // เช็ค G ตัวหน้า
                        {
                            Console.WriteLine("Invalid pattern.");
                        }
                        else if ('G' == FP.Get(FK-1) && 'G' == FP.Get(FK-2)&& 'G' == FP.Get(FK-3)) // เช็ค G ตัวท้าย
                        {
                            Console.WriteLine("Invalid pattern.");
                        }
                        else if (FP.Get(0) == 'G' && FP.Get(-1) == 'G' && FP.Get(-2) == 'G') //
                        {
                            Console.WriteLine("Invalid pattern.");
                        }
                        else if (FP.Get(0) == 'G' && FP.Get(1) == 'G' && FP.Get(-1) == 'G') //
                        {
                            Console.WriteLine("Invalid pattern.");
                        }
                        else
                        {
                        FP.Add(SelectFlower);
                        }
                             
                    }

                }  
                if (SelectFlower == 'J') // Loop J
                {
                    if(FK == 0)
                        {
                            FP.Add(SelectFlower);  
                        }
                    else if (FP.Get(-1) == 'R' && FP.Get(-2) == 'J' ) // ถ้าด้านหน้าเป็น R และ 2 ตัวหน้าเป็น J จะเป็น J ไม่ได้
                        {
                            Console.WriteLine("Invalid pattern.");
                        }
                    else
                    {
                        FP.Add(SelectFlower);
                    }
                }

                if (SelectFlower == 'O') // Loop O
                {
                        if(FK == 0)
                        {
                            FP.Add(SelectFlower);  
                        }
                        else if (FP.Get(-1) == 'R' && FP.Get(-2) == 'O' ) // ถ้าด้านหน้าเป็น R และ 2 ตัวหน้าเป็น O จะเป็น O ไม่ได้
                        {
                            Console.WriteLine("Invalid pattern.");
                        }

                        else
                    {
                        FP.Add(SelectFlower);
                    }
                }
                }
      }
                for(int i = 0 ; i < FP.GetLength(); i++){
                    Console.Write(FP.Get(i));
                }
    }
}

 
