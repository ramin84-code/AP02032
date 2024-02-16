#include<iostream>
using namespace std;

class String{
private:
    char* str;
    int size;
public:
    //String(const string&stri, int m_size): str(stri),size(m_size){};
    String (const  char* s, int m_size){
         
        size = m_size;
        str = (char*)malloc(size*sizeof(char));
        for(int i =0;i<m_size;i++) str[i] = s[i];
        }
    int const len(){return size;}
    char const get(int i ){
        if ( i < size ) return str[i];
         }  
    
    void append(const char* pch) {
        char* r = (char*)malloc(sizeof(char)*(size+sizeof(pch)));
        int j =0;
        //resize(size);
        for (int i =0;i<size;i++) r[i]= str[i];
        while(pch[j]) {
            r[size + j] = pch[j];
            j++;}
        free(str);
        str = r;
        
    }

    //void resize(int newsize){
    //    char* stt = (char*) malloc(newsize* sizeof (char));
    //    for (int j =0;j<newsize;j++) stt[j] = str[j];
    //    free(str);
    //    str= stt;
    //    stt = NULL;
    //    size = newsize;
    //}
};

int main(){
    char s[10] = "rM 12345";
    String st(s,10);
    for (int i = 0 ;i<st.len();i++ ) {
        cout << st.get(i)<< " ";
    };
    cout << endl<< st.len()<< endl;
    char pch1[5] ="78j9";
    cout<< st.append(pch1);
    return 0;
}

