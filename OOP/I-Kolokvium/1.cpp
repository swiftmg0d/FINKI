#include <iostream>
#include <cstring>
using namespace std;

class Gitara{
private:
    char seriski[25];
    double nabavna;
    int godinaProizvodstvo;
    char tip[40];
    public:
        Gitara(char *tip="",char * seriski ="",int godinaProizvodstvo=0,double nabavna =0)
        {
            strcpy(this->tip,tip);
            strcpy(this->seriski,seriski);
            this->godinaProizvodstvo = godinaProizvodstvo;
            this->nabavna = nabavna;
        }

        ~Gitara()
        {
        }
        bool daliIsti(Gitara &g)
        {
         return strcmp(this->seriski,g.seriski)==0;
        }
        void pecati()
        {
            cout<<seriski<<" "<<tip<<" "<<nabavna<<endl;
        }
        double getNabavna()
        {
            return nabavna;
        }
        char * getTip()
        {
            return tip;
        }
        char * getSeriski()
        {
            return seriski;
        }
        int getGodina()
        {
            return godinaProizvodstvo;
        }
};

class Magacin{
private:
    char lokacija[60];
    char ime[50];
    int godinaOtvaranje;
    Gitara * niza;
    int brGitari;
    public:
        Magacin(char * ime="",char * lokacija="",int godinaOtvaranje=0)
        {
            strcpy(this->lokacija,lokacija);
            strcpy(this->ime,ime);
            this->godinaOtvaranje = godinaOtvaranje;
            niza = NULL;
            brGitari = 0;
        }
        Magacin(const Magacin & m)
        {
            strcpy(this->lokacija,m.lokacija);
            strcpy(this->ime,m.ime);
            this->godinaOtvaranje = m.godinaOtvaranje;
            niza = new Gitara[m.brGitari];
            for(int i =0;i<m.brGitari;i++)
                niza[i] = m.niza[i];
            brGitari = m.brGitari;
        }

        Magacin & operator=(const Magacin & m)
        {
            delete [] niza;
            strcpy(this->lokacija,m.lokacija);
            strcpy(this->ime,m.ime);
            this->godinaOtvaranje = m.godinaOtvaranje;
            niza = new Gitara[m.brGitari];
            for(int i =0;i<m.brGitari;i++)
                niza[i] = m.niza[i];
            brGitari = m.brGitari;
            return *this;
        }
        ~Magacin(){delete [] niza;}
        double vrednost()
        {
            double sum=0;
            for(int i=0;i<brGitari;i++)
                sum+=niza[i].getNabavna();
                return sum;

        }
        void dodadi(Gitara & g)
        {
            Gitara * tmp = new Gitara[brGitari +1];
            for(int i=0;i<brGitari;i++)
                tmp[i] = niza[i];
            tmp[brGitari++]=g;
            delete [] niza;
            niza=tmp;

        }
        void prodadi(Gitara & g)
        {
            int newBr = 0;
            for(int i=0;i<brGitari;i++)
            {
                if(niza[i].daliIsti(g)==false)
                {
                    newBr++;
                }
            }
            Gitara * tmp = new Gitara[newBr];
            int j=0;
            for(int i=0;i<brGitari;i++)
            {
                if(niza[i].daliIsti(g)==false)
                {
                   tmp[j] = niza[i];
                   j++;
                }
            }
            delete [] niza;
            niza = tmp;
            brGitari = newBr;
        }
        void pecati(bool daliNovi)
        {
            cout<<ime<<" "<< lokacija<<endl;
            for(int i=0;i<brGitari;i++)
            {
                if(daliNovi==true&&niza[i].getGodina()>godinaOtvaranje)
                {
                    niza[i].pecati();
                }
                else if(daliNovi==false){
                   niza[i].pecati();
                }
            }
        }
};
    int main() {
	// se testira zadacata modularno
    int testCase;
    cin >> testCase;

	int n, godina;
	float cena;
	char seriski[50],tip[50];

	if(testCase == 1) {
        cout << "===== Testiranje na klasata Gitara ======" << endl;
        cin>>tip;
        cin>>seriski;
        cin >> godina;
        cin >> cena;
        Gitara g(tip,seriski, godina,cena);
		cout<<g.getTip()<<endl;
		cout<<g.getSeriski()<<endl;
		cout<<g.getGodina()<<endl;
		cout<<g.getNabavna()<<endl;
    } else if(testCase == 2){
        cout << "===== Testiranje na klasata Magacin so metodot print() ======" << endl;
		Magacin kb("Magacin1","Lokacija1");
        kb.pecati(false);
	}
    else if(testCase == 3) {
        cout << "===== Testiranje na klasata Magacin so metodot dodadi() ======" << endl;
        Magacin kb("Magacin1","Lokacija1",2005);
		cin>>n;
			for (int i=0;i<n;i++){
                cin>>tip;
                cin>>seriski;
                cin >> godina;
                cin >> cena;
                Gitara g(tip,seriski, godina,cena);
                cout<<"gitara dodadi"<<endl;
				kb.dodadi(g);
			}
        kb.pecati(true);
    }

    else if(testCase == 4) {
        cout << "===== Testiranje na klasata Magacin so metodot prodadi() ======" << endl;
        Magacin kb("Magacin1","Lokacija1",2012);
            cin>>n;
            Gitara brisi;
			for (int i=0;i<n;i++){
                cin>>tip;
                cin>>seriski;
                cin >> godina;
                cin >> cena;

                Gitara g(tip,seriski, godina,cena);
                if(i==2)
                    brisi=g;
                cout<<"gitara dodadi"<<endl;
				kb.dodadi(g);
			}
        kb.pecati(false);
        kb.prodadi(brisi);
        kb.pecati(false);
    }
    else if(testCase == 5) {
        cout << "===== Testiranje na klasata Magacin so metodot prodadi() i pecati(true) ======" << endl;
        Magacin kb("Magacin1","Lokacija1",2011);
            cin>>n;
            Gitara brisi;
			for (int i=0;i<n;i++){
                cin>>tip;
                cin>>seriski;
                cin >> godina;
                cin >> cena;

                Gitara g(tip,seriski, godina,cena);
                if(i==2)
                    brisi=g;
                cout<<"gitara dodadi"<<endl;
				kb.dodadi(g);
			}
        kb.pecati(true);
        kb.prodadi(brisi);
        cout<<"Po brisenje:"<<endl;
        Magacin kb3;
        kb3=kb;
        kb3.pecati(true);
    }
   else if(testCase ==6)
        {
        cout << "===== Testiranje na klasata Magacin so metodot vrednost()======" << endl;
        Magacin kb("Magacin1","Lokacija1",2011);
            cin>>n;
            Gitara brisi;
			for (int i=0;i<n;i++){
                cin>>tip;
                cin>>seriski;
                cin >> godina;
                cin >> cena;

                Gitara g(tip,seriski, godina,cena);
                if(i==2)
                    brisi=g;
				kb.dodadi(g);
			}
        cout<<kb.vrednost()<<endl;
        kb.prodadi(brisi);
        cout<<"Po brisenje:"<<endl;
        cout<<kb.vrednost();
        Magacin kb3;
        kb3=kb;
        }
    return 0;
}
