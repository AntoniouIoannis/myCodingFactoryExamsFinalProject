INSERT INTO MUSEUMS (mus_name, mus_desc, mus_coordinate, mus_phone, mus_open, categoty_id, period_id, mus_avg_rate, exhibit_id)
VALUES
    ('������� ��� �������� ��� ���������� ������',
     '�� ������� ��� �������� ��� ���������� ������ ��� ����������� ��������� ���� ��� 400 ������ ����...',
     geography::STPointFromText('POINT(29.119 30.26240)', 4326),
     
     '(+30) 26240 23964',
     '����������: 08:30 - 15:30',
     10, 4, 5, 2),
    
    ('������������ ������� ���������������',
     '��� ������ ������ ��� �������������� �������� ��� ���������� ��� ������� ��� ��������...',
     geography::STPointFromText('POINT(25.856997966 40.8476819)', 4326),
     
     '(+30) 25510 26103',
     '1/11-31/3: �������-������� 08:30-15:30, ����� �������',
     1, 11, 4, 4),

    ('������������ ������� �������',
     'To ������������ ������� ������� ����������� ��� ������� ��� �����...',
     geography::STPointFromText('POINT(24.9537921 40.9810199)', 4326),
     
     '(+30) 25410 51003',
     '1/11-31/3: 08:30 - 15:30',
     1, 8, 3, 7),

    ('������������ ������� ������',
     '�� ������������ �������� ����������� ��� ����������� ������� ��� ������...',
     geography::STPointFromText('POINT(24.1433015 41.1479538)', 4326),
     
     '(+30) 25210 31365',
     '�������-������� 08:30-15:00',
     1, 2, 3, 13),

    ('������������ ������� �������',
     '���� ������ ��� ������������� � ������� ��� ������� ��� ��� ������ ���...',
     geography::STPointFromText('POINT(24.4037281081839 40.93570225)', 4326),
     
     '(+30) 25102 22335',
     '1/11-31/3: 08:30 - 15:30, ����� �������',
     1, 12, 5, 11),
	 

	 INSERT INTO MUSEUMS (mus_name, mus_desc, mus_address, mus_coordinate, mus_phone, mus_open, categoty_id, period_id, mus_avg_rate, exhibit_id)
VALUES
	 ('������� ��������� ������� ��������', '�� ������� ��������� ������� �������� (�.�.�.�.) �������� �� 1964 ��� ��� ������ ��������� ��� �� ���� ���������, �������� �� ����� ������� ������� �������� ���� ������ ��� ��� ����� �������� ����� ��� ��������� ��� �������������� ����������.', '������� 13 ��� ������ 100, 145 62 �������', geography::STPointFromText('POINT(38.07437 23.81466)', 4326), '210 8015870', '���������� 09:00 - 16:00', 6, 13, 5, 6);
	 	 