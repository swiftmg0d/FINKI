#include <stdio.h>
#include "string.h"
typedef struct Pacient{
    char namePacient[100];
    int insurrence;
    int examations;
}Pacient;

typedef struct MaticenDoktor{
    char nameDoctor[100];
    int numPacients;
    Pacient arrayPacients[100];
    float price;
}MaticenDoktor;

void readMaticenDoktor(MaticenDoktor *md,int n){
    for(int i=0;i<n;i++){
        scanf("%s %d %f",md[i].nameDoctor,&md[i].numPacients,&md[i].price);
        for(int j=0;j<md[i].numPacients;j++){
            scanf("%s %d %d",md[i].arrayPacients[j].namePacient,&md[i].arrayPacients[j].insurrence,&md[i].arrayPacients[j].examations);
        }
    }
}

void bestDoctor(MaticenDoktor *md,int n){
    int maxI; float maxSum=0; int maxExam=0;
    for(int i=0;i<n;i++){
        float sum=0; int exam=0;
        for(int j=0;j<md[i].numPacients;j++){
            exam+=md[i].arrayPacients[j].examations;
            if(md[i].arrayPacients[j].insurrence==0){
                sum+=md[i].arrayPacients[j].examations*md[i].price;

            }
        }
        if(sum>maxSum){
            maxSum=sum;
            maxI=i;
            maxExam=exam;
        }else if(sum==maxSum && exam>maxExam){
            maxSum=sum;
            maxI=i;
            maxExam=exam;
        }
    }
    printf("%s %.2f %d",md[maxI].nameDoctor,maxSum,maxExam);
}



int main() {
    int n; scanf("%d",&n); MaticenDoktor md[100];
    readMaticenDoktor(md,n);
    bestDoctor(md,n);
    return 0;
}
