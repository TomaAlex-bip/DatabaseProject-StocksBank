
CREATE TABLE account (
    client_id   NUMBER(9) NOT NULL,
    iban        CHAR(10) NOT NULL,
    card_number CHAR(16),
    balance     NUMBER(15, 4),
    username    VARCHAR2(30) NOT NULL,
    password    VARCHAR2(100) NOT NULL,
    commission  NUMBER(8, 8) NOT NULL
);

ALTER TABLE account
    ADD CONSTRAINT account_iban_ck CHECK ( REGEXP_LIKE ( iban,
                                                         'RO[0-9]{8}' ) );

ALTER TABLE account
    ADD CONSTRAINT account_card_number_ck CHECK ( REGEXP_LIKE ( card_number,
                                                                '[0-9]{16}' ) );

ALTER TABLE account ADD CONSTRAINT account_balance_ck CHECK ( balance >= 0 );

ALTER TABLE account ADD CONSTRAINT account_pk PRIMARY KEY ( client_id );

ALTER TABLE account ADD CONSTRAINT iban_uk UNIQUE ( iban );

ALTER TABLE account ADD CONSTRAINT card_number_uk UNIQUE ( card_number );

ALTER TABLE account ADD CONSTRAINT username_uk UNIQUE ( username );

CREATE TABLE bvb (
    stock_id        VARCHAR2(5) NOT NULL,
    stock_name      VARCHAR2(50) NOT NULL,
    initial_ammount NUMBER(15) NOT NULL,
    ammount_left    NUMBER(15) NOT NULL,
    current_value   NUMBER(10, 4) NOT NULL,
    last_value      NUMBER(10, 4) NOT NULL
);

ALTER TABLE bvb ADD CONSTRAINT bvb_initial_ammount_ck CHECK ( initial_ammount > 0 );

ALTER TABLE bvb ADD CONSTRAINT bvb_ammount_left_ck CHECK ( ammount_left >= 0 );

ALTER TABLE bvb ADD CONSTRAINT bvb_current_value_ck CHECK ( current_value > 0 );

ALTER TABLE bvb ADD CONSTRAINT bvb_last_value_ck CHECK ( last_value > 0 );

ALTER TABLE bvb ADD CONSTRAINT stock_id_pk PRIMARY KEY ( stock_id );

CREATE TABLE client (
    client_id  NUMBER(9) NOT NULL,
    first_name VARCHAR2(20) NOT NULL,
    last_name  VARCHAR2(20) NOT NULL,
    cnp        CHAR(13) NOT NULL
);

ALTER TABLE client
    ADD CONSTRAINT client_first_name_ck CHECK ( REGEXP_LIKE ( first_name,
                                                              '[A-Z][[:alpha:]]+$' ) );

ALTER TABLE client
    ADD CONSTRAINT client_last_name_ck CHECK ( REGEXP_LIKE ( last_name,
                                                             '[A-Z][[:alpha:]]+$' ) );

ALTER TABLE client
    ADD CONSTRAINT client_cnp_ck CHECK ( REGEXP_LIKE ( cnp,
                                                       '[0-9]{13}' ) );

ALTER TABLE client ADD CONSTRAINT client_pk PRIMARY KEY ( client_id );

ALTER TABLE client ADD CONSTRAINT cnp_uk UNIQUE ( cnp );

CREATE TABLE client_details (
    client_id  NUMBER(9) NOT NULL,
    birth_date DATE NOT NULL,
    genre      CHAR(1) NOT NULL,
    city       VARCHAR2(40) NOT NULL,
    address    VARCHAR2(80) NOT NULL,
    phone      CHAR(10) NOT NULL,
    email      VARCHAR2(40)
);

ALTER TABLE client_details
    ADD CONSTRAINT client_details_genre_ck CHECK ( genre = 'M'
                                                   OR genre = 'F' );

ALTER TABLE client_details
    ADD CONSTRAINT client_details_phone_ck CHECK ( REGEXP_LIKE ( phone,
                                                                 '0[2|7][0-9]{8}' ) );
                                                                 
ALTER TABLE client ADD CONSTRAINT client_details_phone_uk UNIQUE ( phone );

ALTER TABLE client_details
    ADD CONSTRAINT client_details_email_ck CHECK ( REGEXP_LIKE ( email,
                                                                 '[a-z0-9._%-]+@[a-z0-9._%-]+\.[a-z]{2,4}' ) );

ALTER TABLE client ADD CONSTRAINT client_details_email_uk UNIQUE ( email );


ALTER TABLE client_details ADD CONSTRAINT client_details_pk PRIMARY KEY ( client_id );

CREATE TABLE invest (
    invest_id        NUMBER(9) NOT NULL,
    ammount          NUMBER(10) NOT NULL,
    aquisition_date  DATE NOT NULL,
    aquisition_price NUMBER(10, 4) NOT NULL,
    client_id        NUMBER(9) NOT NULL,
    stock_id         VARCHAR2(5) NOT NULL
);

ALTER TABLE invest ADD CONSTRAINT invest_id_pk PRIMARY KEY ( invest_id );

CREATE TABLE stock (
    client_id NUMBER(9) NOT NULL,
    stock_id  VARCHAR2(5) NOT NULL,
    ammount   NUMBER(10) NOT NULL
);

ALTER TABLE stock ADD CONSTRAINT stock_ammount_ck CHECK ( ammount >= 0 );

CREATE TABLE transaction (
    transaction_id      NUMBER(9) NOT NULL,
    transaction_details VARCHAR2(20) NOT NULL,
    transaction_date    DATE NOT NULL,
    transaction_cash    NUMBER(15, 2) NOT NULL,
    transaction_iban    VARCHAR2(10),
    client_id           NUMBER(9) NOT NULL
);

--alter table account modify (password varchar(100));

ALTER TABLE transaction
    ADD CONSTRAINT transaction_details_ck CHECK ( transaction_details IN ( 'deposit', 'transfer', 'withdraw' ) );

ALTER TABLE transaction
    ADD CONSTRAINT transaction_iban_ck CHECK ( REGEXP_LIKE ( transaction_iban,
                                                             'RO[0-9]{8}' ) );

ALTER TABLE transaction ADD CONSTRAINT transaction_id_pk PRIMARY KEY ( transaction_id );

ALTER TABLE invest
    ADD CONSTRAINT account_invest_fk FOREIGN KEY ( client_id )
        REFERENCES account ( client_id );

ALTER TABLE stock
    ADD CONSTRAINT account_stock_fk FOREIGN KEY ( client_id )
        REFERENCES account ( client_id );

ALTER TABLE transaction
    ADD CONSTRAINT account_transaction_fk FOREIGN KEY ( client_id )
        REFERENCES account ( client_id );

ALTER TABLE invest
    ADD CONSTRAINT bvb_invest_fk FOREIGN KEY ( stock_id )
        REFERENCES bvb ( stock_id );

ALTER TABLE stock
    ADD CONSTRAINT bvb_stock_fk FOREIGN KEY ( stock_id )
        REFERENCES bvb ( stock_id );

ALTER TABLE account
    ADD CONSTRAINT client_account_fk FOREIGN KEY ( client_id )
        REFERENCES client ( client_id );

ALTER TABLE client_details
    ADD CONSTRAINT client_details_fk FOREIGN KEY ( client_id )
        REFERENCES client ( client_id );

/*
CREATE SEQUENCE client_client_id_seq START WITH 100 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER client_client_id_trg BEFORE
    INSERT ON client
    FOR EACH ROW
    WHEN ( new.client_id IS NULL )
BEGIN
    :new.client_id := client_client_id_seq.nextval;
END;
/

*/

CREATE SEQUENCE invest_invest_id_seq START WITH 1000 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER invest_invest_id_trg BEFORE
    INSERT ON invest
    FOR EACH ROW
    WHEN ( new.invest_id IS NULL )
BEGIN
    :new.invest_id := invest_invest_id_seq.nextval;
END;
/

CREATE SEQUENCE transaction_transaction_id_seq START WITH 1000 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER transaction_transaction_id_trg BEFORE
    INSERT ON transaction
    FOR EACH ROW
    WHEN ( new.transaction_id IS NULL )
BEGIN
    :new.transaction_id := transaction_transaction_id_seq.nextval;
END;
/


/*

DROP TABLE account;
DROP TABLE bvb;
DROP TABLE client;
DROP TABLE client_details;
DROP TABLE invest;
DROP TABLE stock;
DROP TABLE transaction;
DROP SEQUENCE transaction_transaction_id_seq;
DROP SEQUENCE invest_invest_id_seq;
DROP SEQUENCE client_client_id_seq;


DROP TABLE countries;
DROP TABLE departments;
DROP TABLE employees;
DROP TABLE job_grades;
DROP TABLE job_history;
DROP TABLE jobs;
DROP TABLE locations;
DROP TABLE regions;

*/







