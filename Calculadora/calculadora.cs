 class calculadora{
     private int numero1;
     private int numero2;
     public calculadora(){

     }
     public calculadora(int numero1, int numero2){
         this.numero1=numero1;
         this.numero2=numero2;

     }

    
     public int Numero1
     {
         get { return numero1; }
         set { numero1 = value; }
     }
     public int Numero2
     {
         get { return numero2; }
         set { numero2 = value; }
     }
     public int suma(){
         return numero1+numero2;
     }
     public int resta(){
         return numero1-numero2;
     }
     
}