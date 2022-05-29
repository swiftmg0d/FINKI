#include <iostream>
#include <cstring>

using namespace std;

struct Laptop {
    char company[100];
    float monitorSize;
    int touch;
    int price;

    void readLaptop() {
        cin >> company;
        cin >> monitorSize;
        cin >> touch;
        cin >> price;
    }

    void printLaptop() {
        cout << company << " " << monitorSize << " " << price << endl;
    }
};

struct ITStore {
    char nameStore[100];
    char locationStore[100];
    Laptop arrayLaptops[100];
    int num_of_laptops;

    void readITStore() {
        cin >> nameStore >> locationStore>>num_of_laptops;
        for (int i = 0; i < num_of_laptops; i++) {
            arrayLaptops[i].readLaptop();
        }
    }

    void printITStore() {
        cout<<nameStore<<" "<<locationStore<<endl;
        for(int i=0;i<num_of_laptops;i++){
            arrayLaptops[i].printLaptop();
        }
    }

};
void cheapestOffer(ITStore *it,int n){
    int lowest=9999999; int maxJ=0; int maxI=0;
    for(int i=0;i<n;i++){

        for(int j=0;j<it[i].num_of_laptops;j++){
            if(it[i].arrayLaptops[j].price<lowest && it[i].arrayLaptops[j].touch == 1){
                lowest=it[i].arrayLaptops[j].price;
                maxI=i;
                maxJ=j;
            }
        }

    }




    cout<<"Najeftina ponuda ima prodavnicata: \n"<<it[maxI].nameStore<<" "<<it[maxI].locationStore<<endl;
    cout<<"Najniskata cena iznesuva: "<<it[maxI].arrayLaptops[maxJ].price<<endl;

}

int main() {
    ITStore it[30];
    int n;
    cin >> n;
    for (int i = 0; i < n; i++) {
        it[i].readITStore();
    }
    for (int i = 0; i < n; i++) {
        it[i].printITStore();
    }
    cheapestOffer(it,n);
    return 0;
}
