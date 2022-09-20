
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

public class Main {
    public static List<Word> w = new ArrayList<>();

    public static void main(String[] args) throws IOException {
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int n = Integer.parseInt(br.readLine());
        ArrayList<String> arr = new ArrayList<>();
        String word;
        MyComparator myComparator = new MyComparator();

        for(int i = 0; i < n; i++){
           word = br.readLine();
           if(!arr.contains(word)){
               arr.add(word);
               w.add(new Word(word));
           }
        }

        Collections.sort(w, myComparator);

        for(int i = 0; i < arr.size(); i++){
            bw.write(w.get(i).word);
            bw.newLine();
        }
        
        bw.flush();
        bw.close();
        br.close();
    }
}

class Word{
   String word;

    public Word(String w) {
        this.word = w;
    }
}

class MyComparator implements Comparator<Word>{

    @Override
    public int compare(Word o1, Word o2) {
        if(o1.word.length() > o2.word.length()){
            return 1;
        }
        else if(o1.word.length() == o2.word.length()){
            return o1.word.compareTo(o2.word);
        }
        else{
            return -1;
        }
    }   
}