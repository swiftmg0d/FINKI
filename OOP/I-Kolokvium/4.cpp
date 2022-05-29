#include <stdio.h>
#include <stdlib.h>


struct Laptop{
    char company[100];
    float sizeMonitor;
    int touch;
    int price;
};

typedef struct Laptop Laptop;

struct ITStore{
    char storeName[100];
    char location[100];
    Laptop laptop_array[100];
    int num_of_elements;
};

typedef struct ITStore ITStore;

void readLaptop(Laptop *l){
    scanf("%s %f %d %d",l->company,&l->sizeMonitor,&l->touch,&l->price);
}

void readITStore(ITStore *its){
    scanf("%s %s %d",its->storeName,its->location,&its->num_of_elements);
    int i;
    for(i=0;i<its->num_of_elements;i++){
        readLaptop(its->laptop_array+i);
    }
}
void print(ITStore *its,int n){
    int i,j;
    for(i=0;i<n;i++){
        printf("%s %s\n",its[i].storeName,its[i].location);
        for(j=0;j<its[i].num_of_elements;j++){
                if( ((int)(its[i].laptop_array[j].sizeMonitor*10))%10==0)
{
                    printf("%s %d %d\n",its[i].laptop_array[j].company,(int)its[i].laptop_array[j].sizeMonitor,its[i].laptop_array[j].price);
                }else
            printf("%s %.1f %d\n",its[i].laptop_array[j].company,its[i].laptop_array[j].sizeMonitor,its[i].laptop_array[j].price);
        }

    }
}

void lowest(ITStore *its,int n){
    int i,j; int max=99999999; int maxI; int maxJ;
    for(i=0;i<n;i++){
        for(j=0;j<its[i].num_of_elements;j++){

            if(its[i].laptop_array[j].price<max){
                    if(its[i].laptop_array[j].touch){
                         max=its[i].laptop_array[j].price;
                maxI=i; maxJ=j;

                    }

            }
        }
    }
    printf("Najeftina ponuda ima prodavnicata:\n%s %s\n",its[maxI].storeName,its[maxI].location);
    printf("Najniskata cena iznesuva: %d",max);
}


int main()
{
    int i,j,n; scanf("%d",&n); ITStore its[100];

    for(i=0;i<n;i++){
        readITStore(its+i);
    }
    print(its,n);
    lowest(its,n);
    return 0;
}



