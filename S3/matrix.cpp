#include <iostream>

using namespace std;

template<typename T>
class matrix{
    T** ptr;
    size_t Rows;
    size_t Columns;
public:
    matrix(): &ptr = NULL,  Rows= 0, Columns =0;
//{{1,2},{3,4},{5,6}}
    matrix(size_t numRows, size_t numColumns){
        int** arr;
        arr = new ptr[];
        for (int i =0;i<numColumns;i++ ){
            for (int j =0;j<numRows;j++)
                arr[i][j] = ptr[i][j];
        }
    }

    T& at(size_t row, size_t col){
        if (row< Rows) {
            if (col<Columns){
                cout<< T[row][col];
            }
        }
    }

    size_t numRows() const{return Rows;}
    size_t numColumns() const {returnn Columns;}

    ~matrix(){
        delete[] ptr;
    }
    void print(){
        for (int i =0;i<Rows;i++){
            for (int j =0;j<Columns;j++){
                cout << T[i][j] << endl;
            }
        }
    }
};

int main(){
    

    int  r[3][3] = {{1,2},{3,5}};
    matrix <int>m(r,2,2);
}


