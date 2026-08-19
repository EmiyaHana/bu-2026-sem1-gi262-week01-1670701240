using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        As01_CheckNumberSign();
        As02_GetDayName();
        As03_ValidatePassword();
        As04_GetGrade();
        As05_IsLeapYear();
        As06_Calculate();
        As07_GetSeason();
        As08_PurchasingSystemExample();
        As09_RockPaperScissorsExample();
        As10_CalculateWeaponDamage();
        As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign() //Method ที่ใช้หาค่าของ as01Number ว่ามีค่าเป็นบวก, ลบ หรือศูนย์
    {
        if (as01Number > 0) 
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");
        }
    }

    public int as02Day;
    public void As02_GetDayName() //Method ที่ใช้ดูว่าเป็นวันอะไร โดยเริ่มจากวันจันทร์ ไปถึงวันอาทิตย์
    {
        switch (as02Day)
        {
             case 1: Debug.Log("Monday"); break;
             case 2: Debug.Log("Tuesday"); break;
             case 3: Debug.Log("Wednesday"); break;
             case 4: Debug.Log("Thursday"); break;
             case 5: Debug.Log("Friday"); break;
             case 6: Debug.Log("Saturday"); break;
             case 7: Debug.Log("Sunday"); break;
             default: Debug.Log("Invalid day"); break; //ถ้าไม่ใช่เลข 1-7 จะถือว่าหาค่าไม่ได้ เป็นค่าตัวเลขที่ผิด
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        if (as03InputPassword == as03CorrectPassword) //ใช้เช็คว่ารหัสที่ป้อนใส่ ตรงกับรหัสที่ตั้งไว้มั้ย
                                                      //โดยใช้ as03CorrectPassword เป็นรหัสที่ถูกตั้งไว้
                                                      //และ as03InputPassword เป็นรหัสที่ใส่ป้อนลงไป
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public int as04Score;
    public void As04_GetGrade() //Method ที่ใช้วัดคะแนนออกมาเป็นเกรด
    {
        if (as04Score >= 80) //A = 80 ขึ้นไป
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70) //B = 70 ขึ้นไป
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60) //C = 60 ขึ้นไป
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50) //D = 50 ขึ้นไป หรือผ่านครึ่งหนึ่ง
        {
            Debug.Log("D");
        }
        else //F = ต่ำกว่าครึ่งหนึ่ง หรือติดลบ หรือค่าเป็นศูนย์
        {
            Debug.Log("F");
        }
    }

    public int as05Year;
    public void As05_IsLeapYear() //Method ที่ใช้ตรวจดูว่าปีที่ใส่มา เป็นปีอธิกสุรทินหรือเปล่า
                                  //โดยถ้าหารด้วย 400 หรือ 4 ลงตัว จะถือว่าเป็นปีอธิกสุรทินเสมอ
                                  //แม้จะเป็นค่าติดลบ หรือศูนย์ก็ตาม
    {
        if (as05Year % 400 == 0)
        {
            Debug.Log("True");
        }
        else if (as05Year % 100 == 0)
        {
            Debug.Log("False");
        }
        else if (as05Year % 4 == 0)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public double as06Num1;
    public char as06Op; //ใช้บันทึกตัวเลขเพื่อแสดงค่าตัวเลขหลังคำนวณตัวเลขออกมาแล้ว
    public double as06Num2;
    public double result;
    public void As06_Calculate() //Method สำหรับคำนวณตัวเลขด้วยการ +,-,*,/
    {
        switch (as06Op)
        {
             case '+': result = as06Num1 + as06Num2; Debug.Log("Result : " + result); break;
             case '-': result = as06Num1 - as06Num2; Debug.Log("Result : " + result); break;
             case '*': result = as06Num1 * as06Num2; Debug.Log("Result : " + result); break;
             case '/':
                if (as06Num2 == 0) //ในกรณีที่ใช้ 0 หารเลขใดก็ตาม จะหาค่าไม่ได้
                {
                    Debug.Log("Error: Cannot divide by zero.");
                }
                else
                {
                    result = as06Num1 / as06Num2;
                    Debug.Log("Result : " + result);
                }
                break;
             default:
                Debug.Log("Invalid operator. Please use +, -, *, or /."); //ใช้ในกรณีที่ป้อนข้อมูลเป็นสัญลักษณ์อื่น ที่ไม่ใช่ +,-,*,/
                return;
        }
    }

    public int as07Month;
    public void As07_GetSeason() //Method ใช้ดูว่าเป็นฤดูกาลไหน จากเลขที่ใช้เป็นตัวแทนเดือนต่างๆ
                                 //โดยเริ่มจาก 1 (มกราคม) ไปจนถึง 12 (ธันวาคม)
    {
        if (as07Month >= 1 && as07Month <= 12)
        {
            if (as07Month == 12 || as07Month == 1 || as07Month == 2) //ธันวาคม -> กุมภาพันธ์ เป็นฤดูหนาว
            {
                Debug.Log("It's Winter.");
            }
            else if (as07Month >= 3 && as07Month <= 5) //มีนาคม -> พฤษภาคม เป็นฤดูใบไม้ผลิ
            {
                Debug.Log("It's Spring.");
            }
            else if (as07Month >= 6 && as07Month <= 8) //มิถุนายน -> สิงหาคม เป็นฤดูร้อน
            {
                Debug.Log("It's Summer.");
            }
            else if (as07Month >= 9 && as07Month <= 11) //กันยายน -> พฤศจิกายน เป็นฤดูใบไม้ร่วง
            {
                Debug.Log("It's Fall.");
            }
        }
        else
        {
            Debug.Log("Invalid month number. Please enter a number between 1 and 12."); //กรณีใส่เลขอื่นที่ไม่ใช่ 1-12
        }
    }

    public int as08Quantity; //ปริมาณสินค้า
    public int as08Price; //ราคาสินค้า
    public int as08Payment; //เงินที่ใช้จ่าย
    public void As08_PurchasingSystemExample() //Method สำหรับคำนวณการจ่ายเงินซื้อสินค้า
    {
        if (as08Quantity <= 0) //กรณีที่จำนวนสินค้าเป็นศูนย์ หรือติดลบ
        {
            Debug.Log("สินค้าหมด");
        }
        else if (as08Quantity > 0)
        {
            if (as08Payment >= as08Price)
            {
                Debug.Log("คุณได้รับสินค้าแล้ว");
                if (as08Payment - as08Price > 0) //ใช้คำนวณในกรณีที่จ่ายเงินแล้วเงินเหลือ ให้คิดเป็นเงินทอน
                {
                    Debug.Log($"คุณได้รับเงินทอน {as08Payment - as08Price} บาท");
                }
            }
            else if (as08Payment < as08Price)
            {
                Debug.Log("คุณมีเงินไม่พอ");
            }
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample() //Method ที่ตรวจผลแพ้-ชนะ ในการเล่นเป่ายิ้งฉุบ
                                                //โดยวัดที่ผลจากการเลือกผู้ใช้งานเอง
    {
        if (as09UserChoice == 0 || as09UserChoice == 1 || as09UserChoice == 2)
            //  0 = Rock (ค้อน)  ||  1 = Paper (กระดาษ) || 2 = Scissors (กรรไกร)
        {
            if ( as09UserChoice == 0 && as09ComputerChoice == 2 ||
                 as09UserChoice == 1 && as09ComputerChoice == 0 || //ผลชนะ
                 as09UserChoice == 2 && as09ComputerChoice == 1 )
            {
                Debug.Log("คุณชนะ!");
            }
            else if ( as09UserChoice == 0 && as09ComputerChoice == 1 ||
                      as09UserChoice == 1 && as09ComputerChoice == 2 || //ผลแพ้
                      as09UserChoice == 2 && as09ComputerChoice == 0 )
            {
                Debug.Log("คุณแพ้!");
            }
            else //ผลเสมอ
            {
                Debug.Log("เสมอ");
            }
        }
        else //ในกรณีที่ใส่ตัวเลขอื่น ที่ไม่ใช่ 1, 2, 3
        {
            Debug.Log("กรุณาเลือกเป็นตัวเลขที่ถูกต้อง");
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage() //Method ที่ใช้คำนวณดาเมจที่สร้างได้ โดยแต่ละอาวุธแต่ละประเภท
                                             //จะมีตัวคูณค่าดาเมจเสริมที่ต่างกัน
    {
        double multiplier = 1.0;

        //Switch case นี้ มีไว้เพื่อใส่ข้อมูลตัวคูณดาเมจของอาวุธแต่ละประเภท
        switch (as10WeaponType?.ToLower())
        {
            case "sword": multiplier = 1.3; break;
            case "axe": multiplier = 1.4; break;
            case "bow": multiplier = 1.2; break;
            case "staff": multiplier = 1.5; break;
            case "dagger": multiplier = 1.1; break;
            default: multiplier = 1.0; break; //กรณีที่ใส่อาวุธอื่นๆนอกเหนือจากอาวุธข้างต้น หรือไม่ใส่ประเภทอาวุธไว้
        }
        int totalDamage = (int)(as10BaseDamage * multiplier);
        Debug.Log(totalDamage.ToString()); //เป็นการแสดงผลค่าดาเมจ โดยมีการดึงข้อมูลมาจากค่า string
                                           //ซึ่งก็คือข้อมูลของประเภทอาวุธจาก as10WeaponType
    }

    public int as11Score;
    public int as11CompletionTime;
    public string rank;
    public int baseCoins;
    public void As11_DeterminePlayerRank() //Method ที่ใช้คำนวณผลสรุปแรงค์ของผู้เล่นหลังจบเกม
                                           //โดยคำนวณจากคะแนน และเวลาที่ใช้ในการเล่นเกม
                                           //แล้วนำมาคำนวณว่าได้แร้งค์เท่าไหร่ และได้รับเงินจำนวนกี่เหรียญ
    {
        if (as11Score < 0 || as11CompletionTime < 0) //กรณีที่ได้คะแนน หรือใช้เวลาได้น้อยกว่า 0
                                                     //จะถือว่าข้อมูลผิดพลาด ให้ป้อนข้อมูลใหม่
        {
            Debug.Log("Invalid score or time");
            return;
        }

        if (as11Score >= 8000) { rank = "Gold"; baseCoins = 100; } //Gold = ได้คะแนนตั้งแต่ 8000 ขึ้นไป
                                                                   //และได้รับ 100 เหรียญ
        else if (as11Score >= 6000) { rank = "Silver"; baseCoins = 75; } //Sliver = ได้คะแนนตั้งแต่ 6000 ขึ้นไป
                                                                         //และได้รับ 75 เหรียญ
        else if (as11Score >= 4000) { rank = "Bronze"; baseCoins = 50; } //Bronze = ได้คะแนนตั้งแต่ 4000 ขึ้นไป
                                                                         //และได้รับ 50 เหรียญ
        else if (as11Score >= 0) { rank = "Participation"; baseCoins = 25; } //Participation = ได้คะแนนตั้งแต่ 8000 ขึ้นไป
                                                                             //และได้รับ 25 เหรียญ  

        int timeBonus = 0;
        if (as11CompletionTime <= 30) timeBonus = 25; //ถ้าใช้เวลาภายใน 30 นาที ได้ 25 เหรียญ
        else if (as11CompletionTime <= 60) timeBonus = 10; //ถ้าใช้เวลาภายใน 60 นาที ได้ 10 เหรียญ

        int totalCoins = baseCoins + timeBonus; //นำโบนัสเวลาที่ทำได้มาคำนวณเหรียญเพิ่มเติม
        Debug.Log($"{rank} Rank - {totalCoins} coins earned!");
    }
}