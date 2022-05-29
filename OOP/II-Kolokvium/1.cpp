#include<string.h>
#include<iostream>

using namespace std;
class OperationNotSupported {
    char message [50];
public:
    OperationNotSupported(char * message = "test") {
        strcpy(this->message, message);
    }
    void showMessage() {
        cout << message << endl;
    }
};
class User {
    char *username;
    char *companyName;
    int position;

    void copy(const User &u) {
        this->username = new char[strlen(u.username) + 1];
        strcpy(this->username, u.username);
        this->companyName = new char[strlen(u.companyName) + 1];
        strcpy(this->companyName, u.companyName);
        this->position = u.position;
    }

public:
    User(char *username = "", char *companyName = "", int position = 0) {
        this->username = new char[strlen(username) + 1];
        strcpy(this->username, username);
        this->companyName = new char[strlen(companyName) + 1];
        strcpy(this->companyName, companyName);
        this->position = position;
    }

    User(const User &u) {
        copy(u);
    }

    User &operator=(const User &u) {
        if (this != &u) {
            delete[] username;
            delete[] companyName;
            copy(u);
        }
        return *this;
    }

    ~User() {
        delete[] username;
        delete[] companyName;
    }

    char *getUsername() const {
        return username;
    }

    void setUsername(char *username) {
        this->username = new char[strlen(username) + 1];
        strcpy(this->username, username);
    }

    char *getCompanyName() const {
        return companyName;
    }

    void setCompanyName(char *companyName) {
        this->companyName = new char[strlen(companyName) + 1];
        strcpy(this->companyName, companyName);
    }

    int getPosition() const {
        return position;
    }

    void setPosition(int position) {
        this->position = position;
    }


    friend ostream &operator<<(ostream &os, const User &user) {
        return os << "Username: " << user.username
                  << " Company name: " << user.companyName
                  << " Position: " << user.position;
    }

    friend istream &operator>>(istream &in, User &user) {
        return in >> user.username >> user.companyName >> user.position;
    }

    bool operator==(User &u) {
        return strcmp(this->username, u.username) == 0;
    }
};



class Group{
protected:
    User *arrayUsers;
    int numUsers;
    char nameGroup[50];
    void vCopy(const Group & g){
        numUsers=g.numUsers;
        arrayUsers=new User[g.numUsers];
        strcpy(nameGroup,g.nameGroup);
        for(int i=0;i<g.numUsers;i++){
            arrayUsers[i]=g.arrayUsers[i];
        }
    }
public:
    Group(char *nameGroup=""){
        strcpy(this->nameGroup,nameGroup);
        numUsers=0;
        arrayUsers=new User[0];
    }
    Group(const Group & g){
        vCopy(g);
    }
    Group &operator=(const Group & g ){
        if(this!=&g){
            delete [] arrayUsers;
            vCopy(g);
        }
        return *this;
    }
    ~Group(){delete [] arrayUsers;}
     virtual void addMember (User & u){
        User *temp=new User[numUsers+1];
        for(int i=0;i<numUsers;i++){
            if(arrayUsers[i]==u){
               throw OperationNotSupported("Username already exists");
            }
        }

        for(int i=0;i<numUsers;i++){
            temp[i]=arrayUsers[i];
        }
        temp[numUsers++]=u;
        delete [] arrayUsers;
        arrayUsers=temp;

     }
     double avg(){
        double avg=0;
        for(int i=0;i<numUsers;i++){
            avg+=arrayUsers[i].getPosition();
        }
        if(numUsers==0){
            return 0;
        }
        return avg/numUsers;
     }
     virtual double rating(){
        return (10-avg())*(numUsers/100.00);
     }
      friend ostream &operator<<(ostream & out, Group & g){
        out<<"Group: "<<g.nameGroup<<endl;
        out<<"Members: "<<g.numUsers<<endl;
        out<<"Rating: "<<g.rating()<<endl;
        out<<"Members list: "<<endl;
        if(g.numUsers==0){
            out<<"EMPTY"<<endl;
            return out;
        }else{
            for(int i=0;i<g.numUsers;i++){
                out<<i+1<<". "<<g.arrayUsers[i]<<endl;
            }
            return out;
        }
     }
};
class PrivateGroup : public Group{
private:
     static int capacityGroup;
     const static  double coef;
public:
     PrivateGroup(char *nameGroup=""){
        strcpy(this->nameGroup,nameGroup);
        numUsers=0;
        arrayUsers=new User[0];
    }
    double rating(){
       return (10-avg()) * ((double)this->numUsers/capacityGroup) * coef;
    }
    friend ostream &operator<<(ostream & out, PrivateGroup & g){
        out<<"Private Group: "<<g.nameGroup<<endl;
        out<<"Members: "<<g.numUsers<<endl;
        out<<"Rating: "<<g.rating()<<endl;
        out<<"Members list: "<<endl;
        if(g.numUsers==0){
            out<<"EMPTY"<<endl;
            return out;
        }else{
            for(int i=0;i<g.numUsers;i++){
                out<<i+1<<". "<<g.arrayUsers[i]<<endl;
            }
            return out;
        }
     }
     void addMember (User & u){
        if(numUsers==capacityGroup){
            throw OperationNotSupported("The group’s capacity has been exceeded.");
        }
      Group::addMember(u);
     }
     static void setCapacity(int cap){
        capacityGroup=cap;
     }
     static int getCapacity(){
        return capacityGroup;
     }
};
int PrivateGroup::capacityGroup=10;
const double PrivateGroup::coef=0.8;
int main() {
    int testCase;
    cin >> testCase;
    if (testCase == 1) {
        cout << "TESTING CLASS GROUP: CONSTRUCTOR AND OPERATOR <<" << endl;
        Group g("test");
        cout << g;
    } else if (testCase == 2) {
        cout << "TESTING CLASS PRIVATE GROUP: CONSTRUCTOR AND OPERATOR <<" << endl;
        PrivateGroup pg("private test");
        cout << pg;
    } else if (testCase == 3) {
        cout << "TESTING CLASS GROUP: CONSTRUCTOR, METHOD ADD_MEMBER AND OPERATOR <<" << endl;
        Group *g = new Group("FINKI students");
        int n;
        cin >> n;
        for (int i = 0; i < n; i++) {
            User u;
            cin >> u;
            g->addMember(u);
        }
        cout << *g;
        delete g;
    } else if (testCase == 4) {
        cout << "TESTING CLASS PRIVATE_GROUP: CONSTRUCTOR, METHOD ADD_MEMBER AND OPERATOR <<" << endl;
        Group *g = new PrivateGroup("FINKI students");
        int n;
        cin >> n;
        for (int i = 0; i < n; i++) {
            User u;
            cin >> u;
            g->addMember(u);
        }
        cout << *g;
        delete g;
    } else if (testCase == 5) {
        cout << "TESTING CLASS GROUP: CONSTRUCTOR, METHOD ADD_MEMBER, EXCEPTION AND OPERATOR <<" << endl;
        Group *g = new Group("FINKI students");
        int n;
        cin >> n;
        for (int i = 0; i < n; i++) {
            User u;
            cin >> u;
            try {
                g->addMember(u);
            } catch (OperationNotSupported &e) {
                e.showMessage();
            }
        }
        cout << *g;
        delete g;
    }
    else if (testCase == 6) {
        cout << "TESTING CLASS PRIVATE GROUP: CONSTRUCTOR, METHOD ADD_MEMBER, EXCEPTION AND OPERATOR <<" << endl;
        Group *g = new PrivateGroup("FINKI");
        int n;
        cin >> n;
        for (int i = 0; i < n; i++) {
            User u;
            cin >> u;
            try {
                g->addMember(u);
            } catch (OperationNotSupported e) {
                e.showMessage();
            }
        }
        cout << *g;
        delete g;
    } else if (testCase == 7) {
        cout << "TESTING CLASS PRIVATE GROUP: CONSTRUCTOR, METHOD ADD_MEMBER AND CHANGE OF STATIC MEMBER"
             << endl;
        Group *g = new PrivateGroup("FINKI");
        int n;
        cin >> n;
        for (int i = 0; i < n; i++) {
            User u;
            cin >> u;
            g->addMember(u);
        }
        cout << "RATING BEFORE CHANGE" << endl;
        cout << g->rating();
        PrivateGroup::setCapacity(20);
        cout << "RATING AFTER CHANGE" << endl;
        cout << g->rating();
        delete g;
    }
    else if (testCase==8) {
        cout << "TESTING CLASS PRIVATE GROUP: CONSTRUCTOR, METHOD ADD_MEMBER, EXCEPTION AND CHANGE OF STATIC MEMBER"
             << endl;

        Group *g = new PrivateGroup("FINKI");
        int n;
        cin >> n;
        for (int i = 0; i < n; i++) {
            User u;
            cin >> u;
            try {
                g->addMember(u);
            } catch (OperationNotSupported & e) {
                int capacity = PrivateGroup::getCapacity();
                cout<<"Increasing capacity from "<<capacity<<" to "<<capacity+1<<endl;
                PrivateGroup::setCapacity(capacity+1);
                g->addMember(u);
                cout<<g->rating()<<endl;
            }
        }

    }else {
        cout<<"INTEGRATION TEST"<<endl;
        char name [50];
        int nGroups;
        cin>>nGroups;
        Group ** groups = new Group * [nGroups];
        for (int i=0;i<nGroups;i++) {
            int type;
            cin>>type;
            cin>>name;
            if (type==1) { //normal group
                groups[i] = new Group(name);
            } else { //private group
                groups[i] = new PrivateGroup(name);
            }
            int nUsers;
            cin>>nUsers;
            for (int j=0;j<nUsers;j++) {
                User u;
                cin>>u;
                try {
                    groups[i]->addMember(u);
                } catch (OperationNotSupported e) {
                    e.showMessage();
                }
            }
        }

        cout<<"BEFORE CHANGE OF PRIVATE GROUP COEFFICIENT"<<endl;
        for (int i = 0; i < nGroups; ++i) {
            cout<<*groups[i];
        }
        PrivateGroup::setCapacity(15);
        cout<<"AFTER CHANGE OF PRIVATE GROUP COEFFICIENT"<<endl;
        for (int i = 0; i < nGroups; ++i) {
            cout<<*groups[i];
        }
    }
}
