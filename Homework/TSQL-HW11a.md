# TSQL HW 11A
#### --AJ McCray

1. You use variables to temporarily store data values for later use in the same batch in which they were declared. you declare variables with the declare keyword and initialize them with the set keyword. doing both in one line looks like this:

2. The SET statement is safer than the assignment SELECT because it requires you to use a scalar subquery to pull data from a table. Remember that a scalar subquery fails at run time if it returns more than one value.(Pg 363)

3. A batch is one or more T-SQL statements sent by a client application to SQL Server for execution as a single unit transaction is an atomic unit of work. A batch can have multiple transactions, and a transaction can be submitted in parts as multiple batches

4. A transaction can also span across multiple batches. but a transaction cannot directly contain a batch because it is an atomic unit of work.

5. A batch is a unit of resolution (also known as binding). This means that checking the existence of
objects and columns happens at the batch level.

6. Table variables are visible only to the creating session, but because they are variables they have a more limited scope: only the current batch. Table variables are visible neither to inner batches in the call stack nor to subsequent batches in the session


7. You could use the GO operator to run a statement that removes the top row 50 times to get rid of the top 50 entries from your table

8. You use a statement block by using the BEGIN and END keywords


9. There is a case keyword you can use for switch case capability but it cannot be interchanged with the if else construct because you cant use statement blocks with the case keyword since the end keyword is used to end the case

10. Relation focuses on what to get and cursors focus on how to get it. a relation is a set containing unique items in no order, a cursor is a collection that can contain unique items

11.
    - Declare Cursor
    - Open Cursor
    - Fetch rows
    - Close Cursor
    - Deallocate Cursor


12. local to the batch it was defined in

13. when the session ends
