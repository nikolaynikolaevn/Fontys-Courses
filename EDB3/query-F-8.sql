SELECT PRES_NAME
FROM PRESIDENT p
WHERE (SELECT COUNT(*) FROM ELECTION WHERE CANDIDATE = PRES_NAME) = (SELECT SUM(NR_CHILDREN) FROM PRES_MARRIAGE WHERE PRES_NAME = p.PRES_NAME);