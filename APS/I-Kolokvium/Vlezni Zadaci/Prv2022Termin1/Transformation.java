package Prv2022Termin1;

import java.util.Scanner;

class Element {
    private int id;

    public Element(int id) {
        this.id = id;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    @Override
    public String toString() {
        return String.valueOf(id);
    }
}

class SLLNode<E> {
    protected E element;
    protected SLLNode<E> succ;

    public SLLNode(E elem, SLLNode<E> succ) {
        this.element = elem;
        this.succ = succ;
    }

    @Override
    public String toString() {
        return element.toString();
    }
}

class SLL<E> {
    private SLLNode<E> first;

    public SLL() {
        this.first = null;
    }

    public void deleteList() {
        first = null;
    }

    public int length() {
        int ret;
        if (first != null) {
            SLLNode<E> tmp = first;
            ret = 1;
            while (tmp.succ != null) {
                tmp = tmp.succ;
                ret++;
            }
            return ret;
        } else
            return 0;

    }

    @Override
    public String toString() {
        String ret = new String();
        if (first != null) {
            SLLNode<E> tmp = first;
            ret += tmp;
            while (tmp.succ != null) {
                tmp = tmp.succ;
                ret += " -> " + tmp;
            }
        } else
            ret = "Prazna lista!!!";
        return ret;
    }

    public void insertFirst(E o) {
        SLLNode<E> ins = new SLLNode<E>(o, first);
        first = ins;
    }

    public void insertAfter(E o, SLLNode<E> node) {
        if (node != null) {
            SLLNode<E> ins = new SLLNode<E>(o, node.succ);
            node.succ = ins;
        } else {
            System.out.println("Dadenot jazol e null");
        }
    }

    public void insertBefore(E o, SLLNode<E> before) {
        if (first != null) {
            SLLNode<E> tmp = first;
            if (first == before) {
                this.insertFirst(o);
                return;
            }
            while (tmp.succ != before)
                tmp = tmp.succ;
            if (tmp.succ == before) {
                SLLNode<E> ins = new SLLNode<E>(o, before);
                tmp.succ = ins;
            } else {
                System.out.println("Elementot ne postoi vo listata");
            }
        } else {
            System.out.println("Listata e prazna");
        }
    }

    public void insertLast(E o) {
        if (first != null) {
            SLLNode<E> tmp = first;
            while (tmp.succ != null)
                tmp = tmp.succ;
            SLLNode<E> ins = new SLLNode<E>(o, null);
            tmp.succ = ins;
        } else {
            insertFirst(o);
        }
    }

    public E deleteFirst() {
        if (first != null) {
            SLLNode<E> tmp = first;
            first = first.succ;
            return tmp.element;
        } else {
            System.out.println("Listata e prazna");
            return null;
        }
    }

    public E delete(SLLNode<E> node) {
        if (first != null) {
            SLLNode<E> tmp = first;
            if (first == node) {
                return this.deleteFirst();
            }
            while (tmp.succ != node && tmp.succ.succ != null)
                tmp = tmp.succ;
            if (tmp.succ == node) {
                tmp.succ = tmp.succ.succ;
                return node.element;
            } else {
                System.out.println("Elementot ne postoi vo listata");
                return null;
            }
        } else {
            System.out.println("Listata e prazna");
            return null;
        }
    }

    public SLLNode<E> getFirst() {
        return first;
    }

    public void setFirst(SLLNode<E> node){
        first = node;
    }

    public SLLNode<E> find(E o) {
        if (first != null) {
            SLLNode<E> tmp = first;
            while (tmp.element != o && tmp.succ != null)
                tmp = tmp.succ;
            if (tmp.element == o) {
                return tmp;
            } else {
                System.out.println("Elementot ne postoi vo listata");
            }
        } else {
            System.out.println("Listata e prazna");
        }
        return first;
    }
}

public class Transformation {

    private static void listTransform(SLL<Element> original) {
       SLL<SLL<Element>>listSLL=new SLL<>();
       SLLNode<Element>sllNode=original.getFirst();
       int nSize=original.length();
       int nSLL=nSize%10;
       int nSingle=nSize-nSLL;
       while (sllNode!=null){
           SLL<Element>elementSLL=new SLL<>();
            if(nSize%10==0){
                elementSLL.insertLast(sllNode.element);
                elementSLL.insertLast(sllNode.succ.element);
                listSLL.insertLast(elementSLL);
                sllNode=sllNode.succ.succ;
            }else{
                if(nSLL==0){
                    elementSLL.insertLast(sllNode.element);
                    listSLL.insertLast(elementSLL);
                    sllNode=sllNode.succ;
                }
              if(nSLL!=0){
                  elementSLL.insertLast(sllNode.element);
                  elementSLL.insertLast(sllNode.succ.element);
                  listSLL.insertLast(elementSLL);
                  sllNode=sllNode.succ.succ;
                  nSLL--;
              }
            }
       }
        SLLNode<Element>nodeJ=listSLL.getFirst().element.getFirst();
        SLLNode<SLL<Element>>nodeI=listSLL.getFirst();
        System.out.print("[");
        while (nodeI!=null){
            if(nodeI.succ==null){
                System.out.print(nodeI.element.toString());
            }else{
                System.out.print(nodeI.element.toString());
                System.out.print(", ");
            }

          nodeI=nodeI.succ;
        }
        System.out.print("]");

    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int num = Integer.parseInt(scanner.nextLine());
        SLL<Element> list = new SLL<Element>();

        for (int i = 0; i < num; i++) {
            int n = scanner.nextInt();
            list.insertLast(new Element(n));
        }

        listTransform(list);
    }
}
