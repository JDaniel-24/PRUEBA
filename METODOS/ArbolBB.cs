using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_09
{
    internal class ArbolBB
    {
        private Nodo vraiz;

        public Nodo raiz
        {
            get { return vraiz; }
            set { vraiz = value; }
        }
        public ArbolBB()
        {
            raiz = null;
        }
        private Nodo inserta(Nodo r, int dato)
        {
            if (r == null)
            {
                r = new Nodo(dato);
            }
            else
            {
                if (dato < r.info)
                {
                    r.der = inserta(r.izq, dato);
                }
                else
                {
                    if (dato > r.info)
                        r.izq = inserta(r.der, dato);
                }
            }
            return r;
        }
        public void inserta(int dato)
        {
            raiz = inserta(raiz, dato);
        }
        private int BuscarMin(Nodo r)
        {
            int menor = r.info;
            while (r.izq != null)
            {
                menor = r.izq.info;
                r = r.izq;
            }
            return menor;
        }
        public int BuscarMin()
        {
            return BuscarMin(raiz);
        }

        private int BuscarMax(Nodo r)
        {
            int mayor = r.info;
            while (r.der != null)
            {
                mayor = r.der.info;
                r = r.der;
            }
            return mayor;
        }
        public int BuscarMax()
        {
            return BuscarMax(raiz);
        }

        private void preOrden(Nodo r, ListBox lst)
        {
            if (r != null)
            {
                lst.Items.Add(r.info);
                preOrden(r.izq, lst);
                preOrden(r.der, lst);
            }
        }
        public void preOrden(ListBox lst)
        {
            lst.Items.Clear();
            preOrden(raiz, lst);
        }
        private void enOrden(Nodo r, ListBox lst)
        {
            if (r != null)
            {
                enOrden(r.izq, lst);
                lst.Items.Add(r.info);
                enOrden(r.der, lst);
            }
        }
        public void enOrden(ListBox lst)
        {
            lst.Items.Clear();
            enOrden(raiz, lst);
        }
        private void OrdenDescendente(Nodo r, ListBox lst)
        {
            if (r != null)
            {
                OrdenDescendente(r.der, lst);
                lst.Items.Add(r.info);
                OrdenDescendente(r.izq, lst);
            }
        }
        public void OrdenDescendenteen(ListBox lst)
        {
            lst.Items.Clear();
            OrdenDescendente(raiz, lst);
        }
        private void postOrden(Nodo r, ListBox lst)
        {
            if (r != null)
            {
                postOrden(r.izq, lst);
                postOrden(r.der, lst);
                lst.Items.Add(r.info);
            }
        }
        public void postOrden(ListBox lst)
        {
            lst.Items.Clear();
            postOrden(raiz, lst);
        }

        private Nodo eliminarMin(Nodo r)
        {
            if (r.izq == null)
                r = r.der;
            else
                r.izq = eliminarMin(r.izq);
            return r;
        }
        public void eliminarMin()
        {
            raiz = eliminarMin(raiz);
        }
        private int contar(Nodo r)
        {
            if (r == null)
                return 0;
            else
                return 1 + contar(r.izq) + contar(r.der);
        }
        public int contar()
        {
            return contar(raiz);
        }
        private int contarAltura(Nodo r)
        {
            int Altizq, Altder;
            if (r == null)
                return 0;
            else
            {
                Altizq = contarAltura(r.izq);
                Altder = contarAltura(r.der);
                if (Altizq > Altder)
                    return Altizq + 1;
                else
                    return Altder + 1;
            }
        }
        public int contarAltura()
        {
            return contarAltura(raiz);
        }
        private int contarProfundidad(Nodo r)
        {
            int x;

            int Izq = 0;
            int Der = 0;
            if (r == null)
                return 0;
            if (r.izq != null)
                Izq = contarProfundidad(r.izq);
            if (r.der != null)
                Der = contarProfundidad(r.der);
            if (Izq > Der)
                return Izq + 1;
            else
                return Der + 1;
        }
        public int contarProfundidad()
        {
            return contarProfundidad(raiz);
        }
        public Nodo buscar(int x, Nodo r)
        {
            if (r != null)
            {
                if (x == r.info)
                    return r;
                else
                {
                    if (x < r.info)
                        return buscar(x, r.izq);
                    else
                        return buscar(x, r.der);
                }
            }
            else
                return null;
        }
        public Nodo buscar(int x)
        {
            return buscar(x, raiz);
        }
        private int contarHojas(Nodo r)
        {
            int hojas = 0;
            if (r == null)
                return 0;
            if (r.izq == null && r.der == null)
                return 1;
            if (r.izq != null)
                hojas += contarHojas(r.izq);
            if (r.der != null)
                hojas += contarHojas(r.der);
            return hojas;
        }
        public int contarHojas()
        {
            return contarHojas(raiz);
        }
        private int Diferencia(Nodo r)
        {
            if (r == null)
            {
                return 0;
            }
            else
            {
                int Men = BuscarMin();
                int May = BuscarMax();
                return May - Men;
            }
        }
        public int Diferencia()
        {
            return Diferencia(raiz);
        }

        private Nodo elimina(int x, Nodo r)
        {
            if (r != null)
            {
                if (x < r.info)
                    r.izq = elimina(x, r.izq);
                else
                {
                    if (x > r.info)
                        r.der = elimina(x, r.der);
                    else
                    {
                        if (r.izq == null)
                            r = r.der;
                        else
                        {
                            if (r.der == null)
                                r = r.izq;
                            else
                            {
                                r.info = BuscarMin(r.der);
                                r.der = eliminarMin(r.der);
                            }
                        }
                    }
                }
            }
            return r;
        }
        public void elimina(int x)
        {
            raiz = elimina(x, raiz);
        }


    }
}