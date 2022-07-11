using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class CircleOfChildren
{
    IEnumerable<string> children;

    public CircleOfChildren(IEnumerable<string> children)
    {
        this.children = children;
    }

    public IEnumerable GetChildrenInOrder(int syllables, int count = -1)
    {
        if (syllables <= 0 || children.Count() == 0)
        {
            yield break;
        }

        List<string> list = children.ToList();

        if (syllables > 1)
        {
            int cnt = 0;

            for (int i = 0, j = 0; i < list.Count && (count <= 0 || j < count) ; i++, j++)
            {
                cnt += syllables - 1;
                cnt %= list.Count;
                string name = list[cnt];
                list.RemoveAt(cnt);
                --i;

                yield return name;
            }
        }
        else
        {
            for (int i = 0, j = 0; i < list.Count && (count <= 0 || j < count); i++, j++)
            {
                yield return list[i];
            }
        }
    }
}

class OutputUtils
{
    public static void ExitOutput(CircleOfChildren circleOfChilds, int words, int count = -1)
    {
        foreach (string child in circleOfChilds.GetChildrenInOrder(words, count)) 
        {
            Console.Write(child + " "); 
        }
    }
}
