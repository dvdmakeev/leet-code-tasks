/**
 * This is the interface for the expression tree Node.
 * You should not remove it, and you can define some classes to implement it.
 */

public abstract class Node 
{
    public abstract int evaluate();
    // define your fields here
};

public class Number : Node 
{
    private int val;

    public Number(int val)
    {
        this.val = val;
    }
    
    public override int evaluate()
    {
        return val;
    }
}

public class BinaryExpression : Node
{
    private Node left;
    private Node right;
    private string operation;
    
    public BinaryExpression(Node left, Node right, string operation)
    {
        this.left = left;
        this.right = right;
        this.operation = operation;
    }
    
    public override int evaluate()
    {
        switch(operation)
        {
            case "+":
                return left.evaluate() + right.evaluate();
            case "-":
                return left.evaluate() - right.evaluate();
            case "*":
                return left.evaluate() * right.evaluate();
            case "/":
                return left.evaluate() / right.evaluate();
            default:
                throw new NotImplementedException();
        }
    }
}


/**
 * This is the TreeBuilder class.
 * You can treat it as the driver code that takes the postinfix input 
 * and returns the expression tree represnting it as a Node.
 */

public class TreeBuilder 
{
    public Node buildTree(string[] postfix) 
    {
        var stack = new Stack<Node>();
        
        for (int i = 0; i < postfix.Length; ++i)
        {
            string expr = postfix[i];
            int number;
            if (int.TryParse(expr, out number))
            {
                stack.Push(new Number(number));
            }
            else
            {
                var right = stack.Pop();
                var left = stack.Pop();
                
                stack.Push(new BinaryExpression(left, right, expr));
            }
        }
        
        return stack.Pop();
    }
}


/**
 * Your TreeBuilder object will be instantiated and called as such:
 * TreeBuilder obj = new TreeBuilder();
 * Node expTree = obj.buildTree(postfix);
 * int ans = expTree.evaluate();
 */

