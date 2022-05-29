#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct Vozejne{
    char nameVozejne[100];
    int duration;
    float price;
    int studentFee;
};

typedef struct Vozejne Vozejne;

struct ZabavenPark{
    char nameZabavenPark[100];
    char location[100];
    Vozejne arrayVozejne[100];
    int numElements;
};

typedef struct ZabavenPark ZabavenPark;

void readVozejne(Vozejne *v){
    scanf("%s %d %f %d",v->nameVozejne,&v->duration,&v->price,&v->studentFee);
}

void readZabavenPark(ZabavenPark *zp){
    scanf("%s %s %d",zp->nameZabavenPark,zp->location,&zp->numElements); int i;
    for(i=0;i<zp->numElements;i++){
        readVozejne(zp->arrayVozejne+i);
    }
}

void printPark(ZabavenPark *zp,int n){
    int i,j;
    for(i=0;i<n;i++){
        printf("%s %s\n",zp[i].nameZabavenPark,zp[i].location);
        for(j=0;j<zp[i].numElements;j++){
            printf("%s %d %.2f\n",zp[i].arrayVozejne[j].nameVozejne,zp[i].arrayVozejne[j].duration,zp[i].arrayVozejne[j].price);
        }
    }
}

void bestPark(ZabavenPark *zp,int n){
    int i,j; int maxTime=0; int maxFee=0; int maxI=0;
    for(i=0;i<n;i++){
        int time=0; int cnt=0;
        for(j=0;j<zp[i].numElements;j++){
            if(zp[i].arrayVozejne[j].studentFee==1){
                cnt++;
            }
            time+=zp[i].arrayVozejne[j].duration;
        }
        if(cnt>maxFee){
            maxFee=cnt;
            maxI=i;
            maxTime=time;
        }
        else if(cnt==maxFee && time>maxTime){
            maxTime=time;
            maxI=i;
        }


    }
    printf("Najdobar park: %s %s",zp[maxI].nameZabavenPark,zp[maxI].location);
}




int main()
{
    int i,n; scanf("%d",&n); ZabavenPark zPark[100];
    for(i=0;i<n;i++){
        readZabavenPark(zPark+i);
    }
    printPark(zPark,n);
    bestPark(zPark,n);
    return 0;
}
