#include <cstring>

#include <iostream>
#include "algorithm"
using namespace std;
class InvalidOperation{
private:
    char msg[50];
public:
    InvalidOperation(char *msg=""){
        strcpy(this->msg,msg);
    }
    void show(){
        cout<<msg<<endl;
    }
};
class Cryptocurrency{
private:
    char *nameCurrency;
    char codeCurrency[7];
    double priceCoin;
    double numCoins;
    static double PROVISION;
    void vCopy(const Cryptocurrency &c ){
        this->nameCurrency=new char [strlen(c.nameCurrency)+1];
        strcpy(this->nameCurrency,c.nameCurrency);
        strcpy(this->codeCurrency,c.codeCurrency);
        this->priceCoin=c.priceCoin;
        this->numCoins=c.numCoins;
    }
public:
    Cryptocurrency(char *nameCurrency="",char *codeCurrency="",double priceCoin=0.0,double numCoins=0.0){
        this->nameCurrency=new char [strlen(nameCurrency)+1];
        strcpy(this->nameCurrency,nameCurrency);
        strcpy(this->codeCurrency,codeCurrency);
        this->priceCoin=priceCoin;
        this->numCoins=numCoins;
    }
    Cryptocurrency(const Cryptocurrency & c){
        vCopy(c);
    }
    Cryptocurrency &operator=(const Cryptocurrency & c){
        if(this!=&c){
            delete [] nameCurrency;
            vCopy(c);
        }
        return *this;
    }
    ~Cryptocurrency(){
        delete [] nameCurrency;
    }
    char* getCode(){
        return codeCurrency;
    }
    double getPrice(){
        return priceCoin;
    }
    static void setProvision(double provision){
        PROVISION=provision;
    }
    double totalAmount(){
        return numCoins*priceCoin;
    }
    friend ostream &operator<<(ostream & out,Cryptocurrency & c){
        return out<<c.codeCurrency<<" "<<c.nameCurrency<<" "<<c.priceCoin<<" "<<c.numCoins<<" "<<c.totalAmount()<<endl;
    }
    Cryptocurrency &operator+=(Cryptocurrency & c){
        nameCurrency=new char[strlen(nameCurrency)+1];
        if(strcmp(nameCurrency,c.nameCurrency)!=0 && strcmp(codeCurrency,c.codeCurrency)!=0){
            throw InvalidOperation("Can’t merge two different cryptocurrencies.");
        }else{
            strcpy(nameCurrency,c.nameCurrency);
            strcpy(codeCurrency,c.codeCurrency);
            priceCoin=c.priceCoin;
            numCoins=numCoins+c.numCoins;
        }

        return *this;
    }
    double sell() {
        double sold = 0;
        sold=totalAmount()-(totalAmount()*(PROVISION/100.0));
        numCoins=0;
        return sold;
    }
    void set(double s){
        priceCoin=s;
    }
    void set1(double s ){
        numCoins=numCoins+s;
    }
    double getNum(){
        return numCoins;
    }
};
class Wallet {
private:
    char nOwner[40];
    Cryptocurrency *arrayCryptos;
    int numCryptos;
    void vCopy(const Wallet & w){
        strcpy(nOwner,w.nOwner);
        arrayCryptos=new Cryptocurrency[w.numCryptos];
        numCryptos=w.numCryptos;
        for(int i=0;i<w.numCryptos;i++){
            arrayCryptos[i]=w.arrayCryptos[i];
        }
    }
public:
    Wallet(char *nOwner, int numCryptos=0){
        strcpy(this->nOwner, nOwner);
        this->numCryptos=numCryptos;
        arrayCryptos=new Cryptocurrency[0];
    }
    Wallet(const Wallet & w){
        vCopy(w);
    }
    Wallet &operator=(const Wallet & w){
        if(this!=&w){
            delete [] arrayCryptos;
            vCopy(w);
        }
        return *this;
    }
    ~Wallet(){
        delete [] arrayCryptos;
    }
    friend ostream &operator <<(ostream & out, Wallet & w){
        out<<w.nOwner<<endl;
        out<<"Cryptocurrencies:"<<endl;
        if(w.numCryptos==0){
            out<<"EMPTY"<<endl;
            return out;
        }else{
            for(int i=0;i<w.numCryptos;i++){
                cout<<w.arrayCryptos[i];
            }
        }
        return out;
    }
    Wallet &operator+=(Cryptocurrency  & c){
        Cryptocurrency *temp=new Cryptocurrency[numCryptos+1];
        for(int i=0;i<numCryptos;i++){
            if(strcmp(arrayCryptos[i].getCode(),c.getCode())==0){
                arrayCryptos[i].set(c.getPrice());
                arrayCryptos[i].set1(c.getNum());
                return *this;
            }
        }
        copy(arrayCryptos,arrayCryptos+numCryptos,temp);
        temp[numCryptos++]=c;
        delete [] arrayCryptos;
        arrayCryptos=temp;
        return *this;

    }
};
double Cryptocurrency::PROVISION=2.5;
int main() {
    int testCase;
    cin >> testCase;

    if (testCase == 0) {
        cout << "Cryptocurrency constructors" << endl;
        Cryptocurrency c1("Cardano", "ADA", 1.45);
        Cryptocurrency c2("Cardano", "ADA", 1.45, 2.5);
        cout << "TEST PASSED" << endl;
    } else if (testCase == 1) {
        cout << "Cryptocurrency copy-constructor and operator =" << endl;
        Cryptocurrency c2("Cardano", "ADA", 1.45, 2.5);
        Cryptocurrency c1 = c2; //copy-constructor
        Cryptocurrency c3("BITCOIN", "BTC", 35000, 0.0001);
        c3 = c2;
        cout << "TEST PASSED" << endl;
    } else if (testCase == 2) {
        cout << "Cryptocurrency operator <<" << endl;
        Cryptocurrency c1("Cardano", "ADA", 1.45);
        Cryptocurrency c2("Cardano", "ADA", 1.45, 2.5);
        cout << c1;
        cout << c2;
    } else if (testCase == 3) {
        cout << "Cryptocurrency operator += (normal behavior)" << endl;
        Cryptocurrency c1("Cardano", "ADA", 1.45, 8);
        Cryptocurrency c2("Cardano", "ADA", 1.39, 2.5);
        cout<<c1<<"+="<<endl<<c2<<"-->"<<endl;
        cout << (c1 += c2);
    } else if (testCase == 4) {
        cout << "Cryptocurrency operator += (abnormal behavior)" << endl;
        Cryptocurrency c1("Cardano", "ADA", 1.45, 8);
        Cryptocurrency c2("Bitcoin", "BTC", 35000, 0.0008);
        cout<<c1<<"+="<<endl<<c2<<"-->"<<endl;
        try{
            cout << (c1 += c2);
        }
        catch (InvalidOperation i){
            i.show();
        }
    } else if (testCase == 5) {
        cout << "Cryptocurrency method sell and static members test" << endl;
        int n;
        cin >> n;
        Cryptocurrency *cryptocurrencies1 = new Cryptocurrency[n];
        Cryptocurrency *cryptocurrencies2 = new Cryptocurrency[n];
        char name[50], code[7];
        double price, quantity;
        for (int i = 0; i < n; i++) {
            cin >> name >> code >> price >> quantity;
            cryptocurrencies1[i] = Cryptocurrency(name, code, price, quantity);
            cryptocurrencies2[i] = Cryptocurrency(name, code, price, quantity);
        }
        cout << "BEFORE CHANGE OF PROVISION PERCENT" << endl;
        for (int i = 0; i < n; i++) {
            cout << "    BEFORE SELLING --> " << cryptocurrencies1[i];
            cout << "     PROFIT FROM SELLING -->" << cryptocurrencies1[i].sell() << endl;
            cout << "    AFTER SELLING --> " << cryptocurrencies1[i];
        }
        Cryptocurrency::setProvision(5.1);
        cout << "AFTER CHANGE OF PROVISION PERCENT" << endl;
        for (int i = 0; i < n; i++) {
            cout << "    BEFORE SELLING --> " << cryptocurrencies2[i];
            cout << "     PROFIT FROM SELLING -->" << cryptocurrencies2[i].sell() << endl;
            cout << "    AFTER SELLING --> " << cryptocurrencies2[i];
        }

        delete[] cryptocurrencies1;
        delete[] cryptocurrencies2;
    } else if (testCase == 6) {
        cout << "Wallet constructors" << endl;
        Wallet w1("John Doe");
        Wallet w2("John Doe");
        cout << "TEST PASSED" << endl;
    } else if (testCase == 7) {
        cout << "Wallet copy-constructor and operator =" << endl;
        Wallet w1("John Doe");
        Wallet w2("John Doe");
        Wallet w3 = w1; //copy constructor;
        w2 = w1; //operator =
        cout << "TEST PASSED" << endl;
    } else if (testCase == 8) {
        cout << "Wallet operator <<" << endl;
        Wallet w1("John Doe");
        cout << w1;
    } else if (testCase == 9) {
        cout << "Wallet += and <<" << endl;
        Wallet wallet("John Doe");
        int n;
        cin >> n;
        char name[50], code[7];
        double price, quantity;
        for (int i = 0; i < n; i++) {
            cin >> name >> code >> price >> quantity;
            Cryptocurrency c(name, code, price, quantity);
            try{
                wallet += c;
            }
            catch(InvalidOperation i){
                i.show();
            }
        }
        cout << wallet;
    }
    return 0;
}

