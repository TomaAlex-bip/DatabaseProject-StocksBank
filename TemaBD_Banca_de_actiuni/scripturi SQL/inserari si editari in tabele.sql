
-- inserari in tabela CLIENT, CLIENT_DETAILS si ACCOUNT

INSERT INTO client(client_id, first_name, last_name, cnp) VALUES(100, 'Gigel', 'Popescu', '5970323404023');
INSERT INTO client_details VALUES(100, '23.MAR.1997', 'M', 'Bacau', 'Str. Narciselor nr.96', '0735672311', 'gigelpop@gmail.com');
INSERT INTO account VALUES(100, 'RO15783700', '1345857591462748', 1000.00, 'gigipop97', 'qwerty', 0.02);

INSERT INTO client(client_id, first_name, last_name, cnp)  VALUES(101, 'Florinel', 'Bobescu', '5990607007075');
INSERT INTO client_details(client_id, birth_date, genre, city, address, phone) VALUES(101, '07.IUN.1999', 'M', 'Iasi', 'Str. Bahlui nr. 78', '0756992307');
INSERT INTO account(client_id, iban, balance, username, password, commission) VALUES(101, 'RO25383801', 5000, 'florin_bobescu', '123456789', 0.02);

INSERT INTO client(client_id, first_name, last_name, cnp)  VALUES(102, 'Ionela', 'Popescu', '6021017904988');
INSERT INTO client_details VALUES(102, '17.OCT.2002', 'F', 'Brasov', 'Str. Panselutelor nr. 36', '0772397645', 'ionela.frumusika@yahoo.com');
INSERT INTO account(client_id, iban, username, password, commission) VALUES(102, 'RO65003981', 'floricica.dansatoare', 'nuamparola', 0.03);

INSERT INTO client(client_id, first_name, last_name, cnp) VALUES(103, 'Ionel', 'Ionescu', '5870303006442');
INSERT INTO client_details VALUES(103, '03.MAR.1987', 'M', 'Bucuresti', 'Str. Pantelimon nr.46', '0735992101', 'iionescu@yahoo.com');
INSERT INTO account(client_id, iban, username, password, commission) VALUES(103, 'RO65045823', 'ionel.ionescu87', '030387ii', 0.02);

INSERT INTO client(client_id, first_name, last_name, cnp)  VALUES(104, 'Gheorghe', 'Grigorescu', '5630908009902');
INSERT INTO client_details(client_id, birth_date, genre, city, address, phone) VALUES(104, '08.SEP.1963', 'M', 'Iasi', 'Str. Pacurari nr.146', '0234567345');
INSERT INTO account VALUES(104, 'RO65046753', '7523265018902457', 190359.00, 'gheorghe.gri63', 'margareta69', 0.01);

INSERT INTO client(client_id, first_name, last_name, cnp)  VALUES(105, 'Ion', 'Tiriac', '5390509800142');
INSERT INTO client_details VALUES(105, '09.MAI.1939', 'M', 'Bucuresti', 'Str. Centru Vechi nr.31', '0738451182', 'tiriac_ion@gmail.com');
INSERT INTO account VALUES(105, 'RO65049999', '2589456823597725', 4503459.65, 'tiriac.ion.oficial', 'nuosaoghicestiniciodata', 0.01);
--------------------------------------------------------------------------------




-- inserari in tabela BVB

INSERT INTO bvb VALUES('TLV', 'Banca Transilvania S.A.', 6311469680, 6311469680, 2.51, 2.5000);
INSERT INTO bvb VALUES('SNP', 'OMV Petrom S.A.', 56644108335, 56644108335, 0.4430, 0.4507);
INSERT INTO bvb VALUES('M', 'MedLife S.A.', 132870492, 132870492, 22.0000, 21.98);
INSERT INTO bvb VALUES('TRP', 'Teraplast S.A.', 2179000358, 2179000358, 1.0910, 1.049);
INSERT INTO bvb VALUES('SCDM', 'UNIREA SHOPPING CENTER SA Bucuresti', 2749390, 2749390, 68, 65);
INSERT INTO bvb VALUES('MECA', 'METALURGICA SA BUCURESTI', 383208, 383208, 14.2, 15.1);
INSERT INTO bvb VALUES('BIO', 'BIOFARM S.A.', 985375350, 985375350, 0.82, 0.82);
INSERT INTO bvb VALUES('MOBE', 'MOBEST SA BUCURESTI', 17423315, 17423315, 1.16, 1.23);
INSERT INTO bvb VALUES('OIL', 'OIL TERMINAL S.A.', 582430253, 582430253, 0.1745, 0.1745);
INSERT INTO bvb VALUES('AG', 'AGROLAND BUSINESS SYSTEM', 47082360, 47082360, 3.48, 3.455);
INSERT INTO bvb VALUES('BRD', 'BRD - GROUPE SOCIETE GENERALE S.A.', 696901518, 696901518, 17.64, 17.46);
INSERT INTO bvb VALUES('FRB', 'FIREBYTE GAMES', 44022284, 44022284, 0.499, 0.529);
INSERT INTO bvb VALUES('MCAB', 'ROMCAB SA', 9386066, 9386066, 8.45, 9);
INSERT INTO bvb VALUES('ATB', 'ANTIBIOTICE S.A.', 671338040, 671338040, 0.594, 0.6);
INSERT INTO bvb VALUES('CHIA', 'CONSTRUCTII HIDROTEHNICE SA IASI', 521424, 521424, 11.1, 12.6);
INSERT INTO bvb VALUES('MEBY', 'LUCEAFARUL SA BACAU', 195308, 195308, 18.2, 20);
INSERT INTO bvb VALUES('ARS', 'AEROSTAR S.A.', 152277450, 152277450, 8, 7.35);
INSERT INTO bvb VALUES('POBR', 'POIANA BRASOV SA BRASOV', 48896956, 48896956, 0.0295, 0.0143);
INSERT INTO bvb VALUES('SNN', 'S.N. NUCLEARELECTRICA S.A.', 301643894, 301643894, 42.95, 42.7);
INSERT INTO bvb VALUES('FACY', 'FABRICA DE SCULE RASNOV SA', 5650039, 5650039, 8, 8);
INSERT INTO bvb VALUES('ELV', 'ELVILA S.A. BUCURESTI', 26579766, 26579766, 0.75, 0.6);

COMMIT;
--------------------------------------------------------------------------------







