using System;
using System.Collections.Generic;

class Branch
{
    List<Branch> branches;

    public Branch()
    {
        branches = new List<Branch>();
    }

    public void AddLayer(Branch branch)
    {
        branches.Add(branch); // adds a new layer
    }

    public int KnowingTheDepth()
    {
        if (branches.Count == 0)
        {
            return 1; // Base is Depth 1
        }

        int maxDepth = 0;
        foreach (Branch branch in branches)
        {
            int Depth = branch.KnowingTheDepth();
            maxDepth = Math.Max(maxDepth, Depth); // getting the maximum depth using Math.Max
        }

        return maxDepth + 1; // Depth is 1 + max depth of layers since base is 0
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Calling Function
        Branch root = new Branch(); // recursion by creating multiple object Branch()
        Branch branch_1 = new Branch(); // 
        Branch branch_2 = new Branch();
        Branch branch_3 = new Branch();
        Branch branch_4 = new Branch();
        Branch branch_5 = new Branch();
        Branch branch_6 = new Branch();
        Branch branch_7 = new Branch();
        Branch branch_8 = new Branch();
        Branch branch_9 = new Branch();

        // adding layers of branches
        root.AddLayer(branch_1);
        root.AddLayer(branch_2);
        branch_1.AddLayer(branch_3);
        branch_2.AddLayer(branch_3);
        branch_2.AddLayer(branch_4);
        branch_2.AddLayer(branch_5);
        branch_4.AddLayer(branch_6);
        branch_5.AddLayer(branch_7);
        branch_5.AddLayer(branch_8);
        branch_7.AddLayer(branch_9);



        // Getting Depth of Branches
        int depth = root.KnowingTheDepth();
        Console.WriteLine("Depth: " + depth);
    }
}
