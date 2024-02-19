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
    String(const char* pch, int start, int number){
        str = (char*)malloc(number+1);
        for (int i=0;i<number;i++){
            str[i] = pch[start +i]; 
        str[number] = 0;
        }

    }
    int const len(){return size;}
    char const get(int i ){
        if ( i < size ) return str[i];
         }  


    String substr(int start, int count) const{
        return String(str, start, count);
    }
    
    char* append(const char* pch) {
        resize(size+sizeof(pch));
        for (int i =0;i<sizeof(pch);i++) str[size+i] = pch[i];
        return str;
    }
    char* remove(int start, int number){
        for (int i=0;i<size-(start+number);i++) str[start+i]=str[start+number+i];
        //for (int i=start;i<size-count;i++) str[i] = str[i+count];
        str[size - number +1] =0;
        size -= number;
        return str;
    }
private:
    void resize(int newsize){
        char* stt = (char*) malloc(newsize* sizeof (char));
        for (int j =0;j<newsize;j++) stt[j] = str[j];
        free(str);
        stt = NULL;
        size = newsize;
    }
};

int main(){
    char s[10] = "rM 12345";
    String st(s,10);
    for (int i = 0 ;i<st.len();i++ ) {
        cout << st.get(i)<< " ";
    };
    cout << endl<< st.len()<< endl;
    char pch1[5] ={7,8,9,0,6};
    cout<< st.append(pch1)<< "\n";
    cout << st.remove(1,2);
    return 0;
}

