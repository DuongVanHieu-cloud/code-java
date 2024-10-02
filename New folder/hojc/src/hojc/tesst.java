package hojc;

import java.util.ArrayList;

public class tesst {
 public static void main(String[] agrs) {
	 String[] gioHangArray = new String[2];
	 gioHangArray[0] = "Chuoi";
	 gioHangArray[1] = "Thit";
	 
	 
	 ArrayList<String> gioHangArrayList= new ArrayList<String>();  
     gioHangArrayList.add("chuoi");
     gioHangArrayList.add("thit");
     gioHangArrayList.add("cam");
     for (int i = 0; i < gioHangArrayList.size();i++)
     {
    	 System.out.print(gioHangArrayList.get(i));
     }
 
 
 
 }
}
