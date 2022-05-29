#include<iostream>
#include<cstring>
using namespace std;
class MediaSegment{
protected:
    char titleMedia[100];
    char authorMedia[100];
    unsigned int durationMedia;
    unsigned int sizeMedia;
public:
    MediaSegment(char *titleMedia="",char *authorMedia="",unsigned int durationMedia=0,unsigned int sizeMedia=0){
        strcpy(this->titleMedia,titleMedia);
        strcpy(this->authorMedia,authorMedia);
        this->durationMedia=durationMedia;
        this->sizeMedia=sizeMedia;
    }
    virtual double price()=0;
};
enum formatA{
    mp3,wav,ogg,flac
};
class AudioRecording : public virtual MediaSegment{
protected:
    formatA formatAudio;
    short numChannels;
public:
    AudioRecording(char *titleMedia="",char *authorMedia="",unsigned int durationMedia=0,unsigned int sizeMedia=0,int ff=0,short numChannels=0)
            : MediaSegment(titleMedia,authorMedia,durationMedia,sizeMedia){
        this->formatAudio=(formatA)ff;
        this->numChannels=numChannels;
    }
    double price(){
        if(formatAudio==3){
            return (numChannels*durationMedia)*1.5;
        }else
            return numChannels*durationMedia;
    }
    friend ostream &operator<<(ostream & out, AudioRecording & a){
        return out<<a.titleMedia<<" - "<<a.authorMedia<<" - "<<a.durationMedia<<" - "<<a.sizeMedia<<" - "<<a.price()<<endl;
    }
};
enum formatV{
    x264, Theora, AV1
};
class VideoRecording : public virtual MediaSegment{
protected:
    unsigned int widthVideo;
    formatV compresionVideo;
public:
    VideoRecording(char *titleMedia="",char *authorMedia="",unsigned int durationMedia=0,unsigned int sizeMedia=0,unsigned int widthVideo=0,int comp=0)
            : MediaSegment(titleMedia,authorMedia,durationMedia,sizeMedia){
        this->widthVideo=widthVideo;
        this->compresionVideo=(formatV)comp;
    }
    double price(){
        double sum=0;
        if(widthVideo<=1920){
            sum=100*durationMedia;
        } else{
            sum=170*durationMedia;
        }
        if(compresionVideo==0){
            sum*=1.5;
        }else if(compresionVideo==1){
            sum=sum-sum*0.1;
        }
        return sum;
    }
    friend ostream &operator<<(ostream & out, VideoRecording & a){
        return out<<a.titleMedia<<" - "<<a.authorMedia<<" - "<<a.durationMedia<<" - "<<a.sizeMedia<<" - "<<a.widthVideo<<" - "<<a.price()<<endl;
    }
};
class MusicVideo : public AudioRecording, public VideoRecording{
    char dateofPublication[9];
public:
//    MusicVideo mv(title, author, duration, size, format, channels, width, compression, publication_date);
      MusicVideo(char *titleMedia="",char *authorMedia="",unsigned int durationMedia=0,unsigned int sizeMedia=0,int ff=0,short numChannels=0,int widthVideo=0,int comp=0,char *dateofPublication="")
      : MediaSegment(titleMedia,authorMedia,durationMedia,sizeMedia){
        this->formatAudio=(formatA)ff;
        this->numChannels=numChannels;
        this->widthVideo=widthVideo;
        this->compresionVideo=(formatV)comp;
        strcpy(this->dateofPublication,dateofPublication);
    }
    double price(){
    char temp[50];
        strcpy(temp,dateofPublication+4);
        double sPrice=AudioRecording::price()+VideoRecording::price();
    if(strcmp(temp,"2010")>0){
        sPrice*=1.3;
    }
        return sPrice;
    }
    friend ostream &operator << (ostream & out, MusicVideo & m){
        return out<<m.titleMedia<<" - "<<m.authorMedia<<" - "<<m.dateofPublication<<" - "<<m.durationMedia<<" - "<<m.price()<<endl;
    }
    friend ostream &operator << (ostream & out, MusicVideo * m){
        return out<<m->titleMedia<<" - "<<m->authorMedia<<" - "<<m->dateofPublication<<" - "<<m->durationMedia<<" - "<<m->price()<<endl;
    }
};
double total_price(MediaSegment **ptrArray, int num){
    double sum=0;
    for(int i=0;i<num;i++){
        sum+=ptrArray[i]->price();
    }
    return sum;
}
MusicVideo *cheapest_music_video(MediaSegment **segments, int n){
    MusicVideo *min=nullptr;
        for(int i=0;i<n;i++){
                MusicVideo *casted=dynamic_cast<MusicVideo*>(segments[i]);
            if(min==nullptr){
                if(casted){
                    min=casted;
                }
            }else{
                if(casted){
                    if(casted->price()<min->price()){
                        min=casted;
                    }
                }
            }
        }
    return min;
}
using namespace std;
int main() {

    int test_case_num;
    cin>>test_case_num;


    // for MediaSegment
    char title[100];
    char author[1000];
    unsigned int size;
    unsigned int duration;


    // for AudioRecording
    //-------------------
    unsigned short channels;

    // AudioFormat:
    // 0 - mp3
    // 1 - wav
    // 2 - ogg
    // 3 - flac
    unsigned short format;


    // for VideoRecording
    //-------------------
    unsigned short width;

    // VideoCompression:
    // 0 - x264
    // 1 - Theora
    // 2 - AV1
    int compression;


    // for MusicVideo
    //-------------------
    char publication_date[9];


    if (test_case_num == 1){
        cout<<"Testing class AudioRecording and operator<<"<<std::endl;
        cin.get();
        cin.getline(title,100);
        cin.getline(author, 100);
        //cin.get();
        cin >> duration >> size;
        cin >> format >> channels;

        AudioRecording a(title, author, duration, size, format, channels);

        cout<<a;

    }

    else if (test_case_num == 2){
        cout<<"Testing class VideoRecording and operator<<"<<std::endl;
        cin.get();
        cin.getline(title,100);
        cin.getline(author, 100);
        //cin.get();
        cin >> duration >> size;
        cin >> width >> compression;

        VideoRecording v(title, author, duration, size, width, compression);

        cout<<v;

    }

    else if (test_case_num == 3){
        cout<<"Testing class MusicVideo and operator<<"<<std::endl;

        cin.get();
        cin.getline(title,100);
        cin.getline(author, 100);
        //cin.get();
        cin >> duration >> size;

        cin >> format >> channels;
        cin >> width >> compression;

        cin.get();
        cin.getline(publication_date, 9);
        MusicVideo mv(title, author, duration, size, format, channels, width, compression, publication_date);

        cout << mv;
    }

    else if (test_case_num == 4){
        cout<<"Testing function: total_price "<<std::endl;

        MediaSegment ** m;

        int num_media_segments;
        cin >> num_media_segments;

        // 1 - AudioRecording
        // 2 - VideoRecording
        // 3 - MusicVideo
        short media_type;

        m = new MediaSegment*[num_media_segments];

        for (int i=0; i<num_media_segments; i++) {

            cin >> media_type;

            cin.get();
            cin.getline(title,100);
            cin.getline(author, 100);
            //cin.get();
            cin >> duration >> size;

            switch(media_type) {
                case 1:
                    cin >> format >> channels;
                    m[i] = new AudioRecording(title, author, duration, size, format, channels);
                    break;
                case 2:
                    cin >> width >> compression;
                    m[i] = new VideoRecording(title, author, duration, size, width, compression);
                    break;
                case 3:
                    cin >> format >> channels;
                    cin >> width >> compression;
                    cin.get();
                    cin.getline(publication_date, 9);
                    m[i] = new MusicVideo(title, author, duration, size, format, channels, width, compression, publication_date);
                    break;
            }
        }

        //for (int i=0;i<num_media_segments; i++){
        //    cout << *m[i];
        //}

        cout<< "Total price is: " << total_price(m, num_media_segments);

        delete [] m;

    }
    else if (test_case_num == 5){
        cout<<"Testing function: cheapest_music_video "<<std::endl;

        MediaSegment ** m;

        int num_media_segments;
        cin >> num_media_segments;

        // 1 - AudioRecording
        // 2 - VideoRecording
        // 3 - MusicVideo
        short media_type;

        m = new MediaSegment*[num_media_segments];

        for (int i=0; i<num_media_segments; i++) {

            cin >> media_type;

            cin.get();
            cin.getline(title,100);
            cin.getline(author, 100);
            //cin.get();
            cin >> duration >> size;

            switch(media_type) {
                case 1:
                    cin >> format >> channels;
                    m[i] = new AudioRecording(title, author, duration, size, format, channels);
                    break;
                case 2:
                    cin >> width >> compression;
                    m[i] = new VideoRecording(title, author, duration, size, width, compression);
                    break;
                case 3:
                    cin >> format >> channels;
                    cin >> width >> compression;
                    cin.get();
                    cin.getline(publication_date, 9);
                    m[i] = new MusicVideo(title, author, duration, size, format, channels, width, compression, publication_date);
                    break;
            }
        }

       cout<<cheapest_music_video(m,num_media_segments);

        delete [] m;
    }

    return 0;
}
