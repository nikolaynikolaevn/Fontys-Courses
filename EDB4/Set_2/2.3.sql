SET SERVEROUTPUT ON;

BEGIN

DELETE
FROM EMPLOYEES
WHERE EMPLOYEES.salary > 1000 AND EMPLOYEES.salary < 4000;

IF SQL%ROWCOUNT > 20 THEN
DBMS_OUTPUT.PUT_LINE('Too much deleted (' || SQL%ROWCOUNT || ') operation aborted!');
ROLLBACK;

ELSE COMMIT;

END IF;

END;