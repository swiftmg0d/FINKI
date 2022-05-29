#include <iostream>
#include <cstring>
using namespace std;
class  CovidVaccine{
protected:
    char manufacturerVaccine[100];
    char *nameVaccine;
    float coefVaccine;
    void vCopy(const CovidVaccine & c){
        this->nameVaccine=new char[strlen(c.nameVaccine)+1];
        strcpy(this->nameVaccine,c.nameVaccine);
        strcpy(this->manufacturerVaccine,c.manufacturerVaccine);
        this->coefVaccine=c.coefVaccine;
    }
public:
    CovidVaccine( char *manufacturerVaccine="", char *nameVaccine="", float coefVaccine=0 ){
        this->nameVaccine=new char[strlen(nameVaccine)+1];
        strcpy(this->nameVaccine,nameVaccine);
        strcpy(this->manufacturerVaccine,manufacturerVaccine);
        this->coefVaccine=coefVaccine;
    }
    CovidVaccine(const CovidVaccine & c){
        vCopy(c);
    }
    CovidVaccine &operator=(const CovidVaccine & c){
        if(this!=&c){
            delete [] nameVaccine;
            vCopy(c);
        }
    }
    ~CovidVaccine(){
        delete [] nameVaccine;
    }
    virtual double calculateVaccineEfficiency()=0;
    bool operator<=(CovidVaccine & c){
        return calculateVaccineEfficiency()<=c.calculateVaccineEfficiency();
    }
};
enum mechanism{
    RNA,DNA
};
class GeneticVaccine : public CovidVaccine{
private:
    mechanism mGV;
public:
    GeneticVaccine(char *manufacturerVaccine="", char *nameVaccine="", float coefVaccine=0, int type=0 )
            : CovidVaccine(manufacturerVaccine,nameVaccine,coefVaccine){
        mGV=(mechanism)type;
    }
    double calculateVaccineEfficiency(){
        if(mGV==0){
            return coefVaccine*1.35;
        }
        if(mGV==1){
            return coefVaccine*1.55;
        }
    }
    friend ostream &operator<<(ostream & out , GeneticVaccine & c){
        char temp[10];
        out<<"Vaccine info: "<<c.nameVaccine<<" - "<<c.manufacturerVaccine<<" - "<<c.calculateVaccineEfficiency()<<endl;
        if(c.mGV==0){
            strcpy(temp,"RNA");
        }
        else if(c.mGV==1){
            strcpy(temp,"DNA");
        }
        out<<"Mechanism for storing genetic information: "<<temp<<endl;
        return out;
    }
};
enum ingredients{
    DMG, PEG, SM_102, DPSC
};
class InactivatedVaccine : public CovidVaccine{
private:
    ingredients iIV;
public:
    InactivatedVaccine(char *manufacturerVaccine="", char *nameVaccine="", float coefVaccine=0, int type=0 )
            : CovidVaccine(manufacturerVaccine,nameVaccine,coefVaccine){
        iIV=(ingredients)type;
    }
    double calculateVaccineEfficiency(){
        if(iIV==0){
            return coefVaccine-(coefVaccine*0.10);
        }
        else if(iIV==1){
            return coefVaccine*1.12;
        }
        else if(iIV==2){
            return coefVaccine-(coefVaccine*0.15);
        }
        else if(iIV==3){
            return coefVaccine*1.2;
        }
    }
    friend ostream &operator<<(ostream & out , InactivatedVaccine & c){
        char temp[10];
        out<<"Vaccine info: "<<c.nameVaccine<<" - "<<c.manufacturerVaccine<<" - "<<c.calculateVaccineEfficiency()<<endl;
        if(c.iIV==0){
            strcpy(temp,"DMG");
        }
        else if(c.iIV==1){
            strcpy(temp,"PEG");
        }
        else if(c.iIV==2){
            strcpy(temp,"SM_102");
        }
        else if(c.iIV==3){
            strcpy(temp,"DPSC");
        }
        out<<"The vaccine consists of the following ingredient: "<<temp<<endl;
        return out;
    }
};
void mostEffectiveInactivatedVaccine(CovidVaccine **prtArray, int num){
    InactivatedVaccine *temp=nullptr;
    for(int i=0;i<num;i++){
        InactivatedVaccine *k=dynamic_cast<InactivatedVaccine*>(prtArray[i]);
        if(k){
            if(temp== nullptr){
                temp=k;
            }else{
                if(k->calculateVaccineEfficiency() >= temp->calculateVaccineEfficiency()){
                    temp=k;
                }
            }
        }
    }
    cout<<*temp<<endl;
}
using namespace std;
int main() {
    int test_case;

    cin >> test_case;

    //For CovidVaccine
    char manufacturer[100];
    char vaccineName[100];
    float basicEfficiencyCoefficient;

    //For GeneticVaccine
    unsigned short geneticMechanism; // 0 -> RNA, 1 -> DNA

    //For InactivatedVaccine
    unsigned short constituentIngredient; //0 -> DMG, 1 -> PEG, 2 -> SM_102, 3 -> DPSC


    if (test_case == 1) {
        // Test Case GeneticVaccine - Constructor, operator <<, calculateVaccineEfficiency
        cout << "Testing class GeneticVaccine, operator<< and calculateVaccineEfficiency" << endl;
        cin.get();
        cin.getline(manufacturer, 100);
        cin.getline(vaccineName, 100);
        cin >> basicEfficiencyCoefficient;
        cin >> geneticMechanism;

        GeneticVaccine gv(manufacturer, vaccineName, basicEfficiencyCoefficient, geneticMechanism);

        cout << gv;
    } else if (test_case == 2) {
        // Test Case InactivatedVaccine - Constructor, operator <<, calculateVaccineEfficiency
        cout << "Testing class InactivatedVaccine, operator<< and calculateVaccineEfficiency" << endl;
        cin.get();
        cin.getline(manufacturer, 100);
        cin.getline(vaccineName, 100);
        cin >> basicEfficiencyCoefficient;
        cin >> constituentIngredient;

        InactivatedVaccine iv(manufacturer, vaccineName, basicEfficiencyCoefficient, constituentIngredient);

        cout << iv;
    } else if (test_case == 3) {
        cout << "Testing operator <=" << endl;

        cin.get();
        cin.getline(manufacturer, 100);
        cin.getline(vaccineName, 100);
        cin >> basicEfficiencyCoefficient;
        cin >> geneticMechanism;

        GeneticVaccine gv(manufacturer, vaccineName, basicEfficiencyCoefficient, geneticMechanism);

        cin.get();
        cin.getline(manufacturer, 100);
        cin.getline(vaccineName, 100);
        cin >> basicEfficiencyCoefficient;
        cin >> constituentIngredient;

        InactivatedVaccine iv(manufacturer, vaccineName, basicEfficiencyCoefficient, constituentIngredient);

        if (gv <= iv) {
            cout << iv;
        } else {
            cout << gv;
        }
    } else if (test_case == 4) {
        cout << "Testing operator <=" << endl;

        cin.get();
        cin.getline(manufacturer, 100);
        cin.getline(vaccineName, 100);
        cin >> basicEfficiencyCoefficient;
        cin >> geneticMechanism;

        GeneticVaccine gv1(manufacturer, vaccineName, basicEfficiencyCoefficient, geneticMechanism);

        cin.get();
        cin.getline(manufacturer, 100);
        cin.getline(vaccineName, 100);
        cin >> basicEfficiencyCoefficient;
        cin >> geneticMechanism;

        GeneticVaccine gv2(manufacturer, vaccineName, basicEfficiencyCoefficient, geneticMechanism);

        if (gv1 <= gv2) {
            cout << gv2;
        } else {
            cout << gv1;
        }
    }
    else if (test_case == 5) {
        cout << "Testing function: mostEffectiveInactivatedVaccine " << endl;

        //1 - GeneticVaccine
        //2 - InactivatedVaccine
        short vaccineType;

        int number_of_vaccines;
        CovidVaccine **vaccine_array;

        cin >> number_of_vaccines;

        vaccine_array = new CovidVaccine *[number_of_vaccines];

        for (int i = 0; i < number_of_vaccines; ++i) {
            cin >> vaccineType;

            cin.get();
            cin.getline(manufacturer, 100);
            cin.getline(vaccineName, 100);
            cin >> basicEfficiencyCoefficient;

            switch (vaccineType) {
                case 1:
                    cin >> geneticMechanism;
                    vaccine_array[i] = new GeneticVaccine(manufacturer, vaccineName, basicEfficiencyCoefficient,
                                                          geneticMechanism);
                    break;
                case 2:
                    cin >> constituentIngredient;
                    vaccine_array[i] = new InactivatedVaccine(manufacturer, vaccineName, basicEfficiencyCoefficient,
                                                              constituentIngredient);
                    break;
            }

        }

        mostEffectiveInactivatedVaccine(vaccine_array, number_of_vaccines);
        delete[] vaccine_array;
    }

    return 0;
}
