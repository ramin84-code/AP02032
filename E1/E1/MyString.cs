namespace E1;

public class MyString
{
    public string mystr{get;}
    //public MyString(string str){
    //    this.mystr = str;
    //}
    //public bool  operator ==()
    #region TODO
        public MyString(string Str){
                this.mystr = Str;
        }
        public static explicit operator string(MyString s){
            string ss = s.mystr;
            return  ss;
        }
        public static implicit operator  MyString(string my)=>new MyString(my);
        public override string ToString()
        {
            return this.mystr;
        }
        public static MyString operator ++(MyString my){
            return new MyString(my.mystr.ToUpper().ToString());
        }
        public static MyString operator --(MyString me){
            return new MyString(me.mystr.ToLower().ToString());
        }
        //public static bool operator ==(string s1, string s2)=>s1 == s2;
        //public static bool operator !=(string s2, string s3)=> s2!=s3;
        public static bool operator == (MyString st, string s)=>st.mystr ==s;
        public static bool operator != (MyString st, string ste)=> st.mystr!= ste;
        //public static bool operator (object obj, object other)=> obj.Equals(other);
        //public  object  Equals(object obj1)=>obj1 .Equals ;
        
    #endregion
}
