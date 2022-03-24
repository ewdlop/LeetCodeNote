using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNote;

public partial interface ISolution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);
        int i = 0, j = people.Length - 1;
        int ans = 0;

        while (i <= j)
        {
            ans++;
            if (people[i] + people[j] <= limit)
                i++;
            j--;
        }

        return ans;
    }

    public int NumberOfRescueBoats(ref int[] people, int limit, bool isSorted = false)
    {
        if(!isSorted)Array.Sort(people);
        int i = 0, j = people.Length - 1;
        int ans = 0;

        while (i <= j)
        {
            ans++;
            if (people[i] + people[j] <= limit)
                i++;
            j--;
        }

        return ans;
    }
    public int NumberOfRescueBoats(int[] people, int limit, bool isSorted = false)
    {
        int i = 0, j = people.Length - 1;
        int ans = 0;
        if (!isSorted)
        {
            ImmutableSortedSet<int> sortedPeople = people.ToImmutableSortedSet();
            while (i <= j)
            {
                ans++;
                if (sortedPeople[i] + sortedPeople[j] <= limit)
                    i++;
                j--;
            }
        }
        else
        {
            while (i <= j)
            {
                ans++;
                if (people[i] + people[j] <= limit)
                    i++;
                j--;
            }
        }
        return ans;
    }
}
