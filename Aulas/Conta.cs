using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo {
    class Conta {
        private int _numeroConta;
        private string _titular;
        private double _saldo;



        public Conta() {
            _saldo = 0.0;
        }


        public void setNumeroConta(int numeroConta) {
            _numeroConta = numeroConta;
        }
        public double getNumeroConta() {
            return _numeroConta;
        }

        public void setTitular(string titular) {
            _titular = titular;
        }

        public string getTitular() {
            return _titular;
        }

        public void setSaldo(double saldo) {
            _saldo = saldo;
        }

        public double getSaldo() {
            return _saldo;
        }

        public override string ToString() {
            return "Conta " + getNumeroConta() + ", Titular: "
                + getTitular() + ", Saldo: R$ " + getSaldo().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void deposito() {
            Console.WriteLine("Informe o valor para dépósito: ");
            double valor = (double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            setSaldo(getSaldo() + valor);


        }

        public void saque() {
            Console.WriteLine("Informe o valor para saque: ");
            double valor = (double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            if (valor <= getSaldo()) {
                setSaldo(getSaldo() - valor);

            }else {
                Console.WriteLine("Saldo insuficiente");
             }
        }

    }



}

