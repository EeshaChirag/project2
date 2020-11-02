using System;


namespace HW
{
    class Balance : Exception
    {
        public Balance(string x) : base(x)
        {

        }
    }
    class LoanProcess
    {
        int loanno;
        string customername;
        float loanamt;
        float emiamount;
        float accountbalance;
        int roi = 13;
        int year = 3;
        string ERR;

        internal LoanProcess(int loanno, string customername, float loanamt, float accountbalance)
        {
            this.loanno=loanno;
            this.customername=customername;
            this.loanamt=loanamt;
            this.accountbalance=accountbalance;
            //this.emiamount = emiamount;

        }
        public float CalculateEmi()
        {
            float r = roi / (12 * 100); // one month interest  
            int m = year * 12; // one year interest
            emiamount = (loanamt * r * (float)Math.Pow(1 + r, m)) / ((float)Math.Pow(1 + r, m) - 1);
            return emiamount;
        }

        public void CheckBalance()
        {
            try
            {
                if(accountbalance<emiamount)
                {
                    throw new Balance("Not sufficient balance to repay amount");
                }
                else
                {
                    Console.WriteLine("EMI Amount is deducted");
                }
            }
            catch (Exception e)
            {
                ERR = e.Message;
                Console.WriteLine(e.Message);
            }

            finally
            {
                if(ERR!=null)
                {
                    Console.WriteLine("No sufficient fund to repay loan");
                }
                else
                {
                    Console.WriteLine("EMI has been paid");
                }

            }
        }

        public void Display()
        {
            emiamount = CalculateEmi();
            Console.WriteLine("Loan number:{0}, Customer Name:{1}, Loan amount:{2}, Account balance:{3}, EMI Amount:{4}", loanno, customername, loanamt, accountbalance, emiamount);
        }
    }
    class Bank
    {
        static void Main()
        {
            int loanno ;
            string customername;
            float loanamt;
            float accountbalance;

            Console.Write("Enter Loan Number:");
            loanno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name:");
            customername = Console.ReadLine();

            Console.Write("Enter Loan Amount:");
            loanamt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Account Balance:");
            accountbalance = Convert.ToInt32(Console.ReadLine());

            

            LoanProcess l = new LoanProcess(loanno, customername, loanamt, accountbalance);
            l.Display();
            l.CheckBalance();
            Console.Read();
        }
    }
}
