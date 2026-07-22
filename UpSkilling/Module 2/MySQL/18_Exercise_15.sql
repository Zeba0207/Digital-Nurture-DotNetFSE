-- Exercise 15: Event Session Time Conflict

SELECT
    e.title AS event_name,
    s1.title AS session_1,
    s2.title AS session_2,
    s1.start_time AS session1_start,
    s1.end_time AS session1_end,
    s2.start_time AS session2_start,
    s2.end_time AS session2_end
FROM Sessions s1
JOIN Sessions s2
    ON s1.event_id = s2.event_id
    AND s1.session_id < s2.session_id
JOIN Events e
    ON s1.event_id = e.event_id
WHERE
    s1.start_time < s2.end_time
    AND s1.end_time > s2.start_time;