using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance
{//overrididing method
    public class Employee
    {

        protected int id, salary;
        protected string name;
        protected double hra, da, pf, gross, net;
        private static int count;
        public Employee(string name, int salary)

        {
            count++;
            this.id = count;
            this.name = name;
            this.salary = salary;

        }
        public virtual void Calculatesalary()
        {
            hra = salary * 0.4;
            da = salary * 0.2;
            gross = salary + da + hra;
            pf = salary * 0.12;
            net = gross - pf;
        }
        public static string TotalCounts()
        {
            return $"the counted value is:{count}";

        }
        public override string ToString()
        {
            return $"EMPLOYEE ID {id}  NAME {name}  GROSS SALARY {gross} NET SALARY{net}";
        }

        public class Manager : Employee
        {
            private int ta;
            public Manager(string name, int bs, int ta) : base(name, bs)
            {
                this.ta = ta;


            }
            public override void Calculatesalary()
            {
                hra = salary * 0.4;
                da = salary * 0.2;
                gross = salary + da + hra;
                pf = salary * 0.12;
                net = gross - pf + ta;
            }
            public override string ToString()
            {
                return $"MANAGER ID {id}  NAME {name}  GROSS SALARY {gross} NET SALARY{net}";
            }
        }
        public class President : Employee
        {
            private int fuel, health, pallowances;
            public President(string name, int bs, int fuel, int health, int pallowances) : base(name, bs)
            {
                this.fuel = fuel;
                this.health = health;
                this.pallowances = pallowances;



            }
            public override void Calculatesalary()
            {
                hra = salary * 0.4;
                da = salary * 0.2;
                gross = salary + da + hra;
                pf = salary * 0.12;
                net = gross - pf + fuel+health+ pallowances;
            }
            public override string ToString()
            {
                return $" President  {id}  NAME {name}  GROSS SALARY {gross} NET SALARY{net}";
            }
        }

        public class Sales : Employee
        {
            private int add, comm, health, bonus;
            
            public Sales(string name, int bs, int add,int comm,int health,int bonus) : base(name, bs)
            {
                this.add= add;
                this.comm= comm;
                this.health= health;
                this.bonus= bonus;


            }
            public override void Calculatesalary()
            {
                hra = salary * 0.4;
                da = salary * 0.2;
                gross = salary + da + hra;
                pf = salary * 0.12;
                net = gross - pf + add+comm+health+bonus;
            }
            public override string ToString()
            {
                return $" sales id {id}  NAME {name}  GROSS SALARY {gross} NET SALARY{net}";
            }
        }




    }
}

    

