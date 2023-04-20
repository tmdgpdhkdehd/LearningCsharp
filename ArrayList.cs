using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // ArrayList는 List와 달리 여러 가지 자료형을 넣을 수 있다.
        // 단점은 느리다!
        ArrayList al = new ArrayList();

        // 요소 추가
        al.Add("apple");
        al.Add("banana");
        al.Add("orange");

        // 요소 삽입
        al.Insert(1, "grape");

        // 요소 삭제
        al.Remove("banana");

        // 전체 요소 출력
        foreach (var element in al)
        {
            Console.WriteLine(element);
        }

        // 요소 개수 출력
        Console.WriteLine("요소 개수: " + al.Count);

        // 모든 요소 삭제
        al.Clear();
    }
}
