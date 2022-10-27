import java.util.*;

public class Main {

    public static void main(String[] args) {

        List<String> rpg = new ArrayList<String>();

        rpg.add("3:勇者");
        rpg.add("2:賢者");
        rpg.add("1:魔導士");

        print("--List for-----");

        for (int i = 0; i < rpg.size(); i++) {
            print( rpg.get(i) );
        }

        print("--List 拡張 for--");

        for (var string : rpg) {
            print( string );
        }

        print("--Sort----");

        Collections.sort(rpg);

        for (String string : rpg) {
            print( string );
        }

        print("--toArray--");

        var skill = rpg.toArray(new String[0]);
        for (int i = 0; i < skill.length; i++) {
            print(skill[i]);
        }

        print("--配列拡張 for--");

        for (String string : skill) {
            print( string );
        }

        print("--asList--");

        List<String> list = Arrays.asList(skill);
        for (String string : list) {
            print( string );
        }

        print("--再List化--");

        List<String> listOk = new ArrayList<String>(list);
        for (String string : listOk) {
            print( string );
        }

        print("--Array forEach ラムダ式-");
        listOk.forEach((s) ->  {
            print(s);
        });

        print("--List forEach-ラムダ式-");
        rpg.forEach((s) -> {
            print(s);
        });


    }

    private static void print(String string) {
        System.out.println(string);
    }

}
