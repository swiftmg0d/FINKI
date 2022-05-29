#include <stdio.h>
#include <stdlib.h>
#include <string.h>
struct Tanc{
    char nameTanc[15];
    char countryTanc[15];
};

typedef struct Tanc Tanc;

struct Tancer{
    char firstName[15];
    char lastName[15];
    Tanc arrayTanc[5];
};

typedef struct Tancer Tancer;

void readTanc(Tanc *tr){
    scanf("%s ",tr->nameTanc,tr->countryTanc);
    scanf("%s ",tr->countryTanc);
}

void readTancer(Tancer *t){
    scanf("%s ",t->firstName,t->firstName);
    scanf("%s ",t->lastName); int i;
    for(i=0;i<3;i++){
        readTanc(t->arrayTanc+i);
    }
}
void tancuvajne(Tancer *ts,int n, char *country){
    int i,j; int cnt=0;
    for(i=0;i<n;i++){
        int cnt=0;
        for(j=0;j<3;j++){
            if(strcmp(ts[i].arrayTanc[j].countryTanc,country)==0){
                cnt++;
                if(cnt>1){break;}
                printf("%s %s, %s\n",ts[i].firstName,ts[i].lastName,ts[i].arrayTanc[j].nameTanc);

            }
        }
    }

}

int main()
{
    int i,n; char country[100]; Tancer arTancer[100];
    scanf("%d",&n);
    for(i=0;i<n;i++){
        readTancer(arTancer+i);
    }
    scanf("%s",country);
    tancuvajne(arTancer,n,country);
    return 0;
}
