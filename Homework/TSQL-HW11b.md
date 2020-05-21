# TSQL HW 11B
#### --AJ McCray

1. Dynamic sql is a capability that allows you to construct a batch of tsql code as a character string and then execute it

2. The EXEC command accepts a character string in parentheses as input and executes the batch of code within the character string. execute has an interface; that is, it supports input and output parameters and it only supports unicode character strings

3. Sql injection is when a hacker incorporates sql into an input string in an attempt to get the database to run the command. if the input string is concatenated, it is possible for the hacker to run commands through the input string like running a command to drop a table through the input form

4.
  - DECLARE @sql AS VARCHAR(100);
  - SET @sql = 'PRINT ''This message was printed by a dynamic SQL batch.'';';
  - EXEC(@sql);

5. There are two input parameters, one holding your batch of code, the second

6. What are the three kinds of routines that T-SQL recognizes?

7. The purpose of a user-defined function (UDF) is to encapsulate logic that calculates something, possibly based on input parameters, and return a result. Stored procedures are routines that encapsulate code. They can have input and output parameters, they can return result sets of queries, and they are allowed to have side effects.

8. A udf seems like a good choice to use to provide views to perform evaluations, transforms an expression into a value

9. Side effects are unintended changes done to your data through your stored procedures and they're so dangerous because the changes aren't necessarily obvious and can be hard to track down

side effects are changes made outside the scope of execution
10. A stored procedure can have side effects. User defined functions evaluate to a value; they cannot have side effects

11. you dont have to write it every time you need it to run, attached to an event it will run whenever triggered

12. No
