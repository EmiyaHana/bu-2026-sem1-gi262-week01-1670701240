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
        // As09_RockPaperScissorsExample();
        // As10_CalculateWeaponDamage();
        // As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
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
    public void As02_GetDayName()
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
             default: Debug.Log("Invalid day"); break;
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        if (as03InputPassword == as03CorrectPassword)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        if (as04Score >= 80)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        if (as05Year % 400 == 0)
        {
            Debug.Log("True");
        }
        else if (as05Year % 100 == 0)
        {
            Debug.Log("False");
        }
        else if (as05Year % 4 == 0){
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public double result;
    public void As06_Calculate()
    {
        switch (as06Op)
        {
             case '+': result = as06Num1 + as06Num2; Debug.Log("Result : " + result); break;
             case '-': result = as06Num1 - as06Num2; Debug.Log("Result : " + result); break;
             case '*': result = as06Num1 * as06Num2; Debug.Log("Result : " + result); break;
             case '/':
                if (as06Num2 == 0)
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
                Debug.Log("Invalid operator. Please use +, -, *, or /.");
                return;
        }
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        if (as07Month >= 1 && as07Month <= 12)
        {
            if (as07Month == 12 || as07Month == 1 || as07Month == 2)
            {
                Debug.Log("It's Winter.");
            }
            else if (as07Month >= 3 && as07Month <= 5)
            {
                Debug.Log("It's Spring.");
            }
            else if (as07Month >= 6 && as07Month <= 8)
            {
                Debug.Log("It's Summer.");
            }
            else if (as07Month >= 9 && as07Month <= 11)
            {
                Debug.Log("It's Fall.");
            }
            else
            {
                Debug.Log("Invalid month number. Please enter a number between 1 and 12.");
            }
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        if (as08Quantity <= 0)
        {
            Debug.Log("Out of Stock.");
        }
        else if (as08Quantity > 0)
        {
            if (as08Payment >= as08Price)
            {
                Debug.Log("Got the Item.");
                if (as08Payment - as08Price > 0)
                {
                    Debug.Log($"You recieve changes : {as08Payment - as08Price}.");
                }
            }
            else if (as08Payment < as08Price)
            {
                Debug.Log("The payment is not enough.");
            }
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        throw new System.NotImplementedException();
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        throw new System.NotImplementedException();
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        throw new System.NotImplementedException();
    }
}
