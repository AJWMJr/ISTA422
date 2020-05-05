1. Temporal tables allow you to reconstitute a data state from anytime between creation and the present

2. In a banking environment

3. A primary key,
 -two datetime columns that represent the start and end of a row's validity,
 -a start column,
 -an end column,
 -a designation of the period column with the option PERRIOD FOR SYSTEM_TIME,
 -The table option SYSTEM_VERSIONING (set to on), a linked history table

4. Run a query

5. the same way you would another table using a modify statement/s

6. you do not delete data from a history table

7. The same way you search a normal table

8. You query the current table, but you add the clause called FOR SYSTEM_TIME and a subclause that indicates the validity point or period of time you're interested in.

9. DROP TABLE IF EXISTS temporalTable;
