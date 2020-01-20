create database netplusbeta;
go
use netplusbeta;
GO
set dateformat dmy;
GO
create table empleados(
    cod_empleado int identity,
    usuario varchar(20),
    contrasena varchar(20),
    nombre varchar(50),
    apellido varchar(50),
    primary key(cod_empleado)
  );
go

INSERT INTO empleados VALUES ('admin','admin','Juan','Perez');
INSERT INTO empleados VALUES ('jimmy','jimmy','Jimmy','Carguamango');
  
  create table clientes(
    id_cliente VARCHAR(8),
    nombre varchar(50),
    apellido varchar(50),
    direccion varchar(200),
    zona varchar(50),
    celular varchar(12),
    email varchar(50),
    estado_cliente varchar(10)
    PRIMARY KEY(id_cliente)
  );
GO
INSERT INTO clientes VALUES('70889470','Maximo Junior','Apaza Chirhuana','mz M lt 15 Eden del Manantial','Lomas','92715648','maximopeoficiales@gmail.com','ACTIVO');
INSERT INTO clientes VALUES('10012164','Juan','Perez Galvez','La laguna de Oxidacion','La cantera','998144600','juanhz@gmail.com','ACTIVO');

  CREATE TABLE planes(
    id_plan VARCHAR(20),
    descripcion VARCHAR(200),
    PRIMARY KEY(id_plan)
  );
  GO
INSERT INTO planes VALUES(
    'PLAN1','CABLE CON 250 CANALES'
);
INSERT INTO planes VALUES(
    'PLAN2','CABLE CON 250 CANALES + CANALES PREMIUM'
);
INSERT INTO planes VALUES(
    'PLANI1','1MB DE INTERNET ILIMITADO'
);
INSERT INTO planes VALUES(
    'PLANI2','4MB DE INTERNET ILIMITADO'
);
INSERT INTO planes VALUES(
    'PLANI3','8MB DE INTERNET ILIMITADO'
);
INSERT INTO planes VALUES(
    'DUO1','1MB DE INTERNET ILIMITADO + CABLE'
);
INSERT INTO planes VALUES(
    'DUO2','4MB DE INTERNET ILIMITADO + CABLE'
);
INSERT INTO planes VALUES(
    'DUO3','8MB DE INTERNET ILIMITADO + CABLE PREMIUM'
);

  CREATE TABLE servicios(
    id_servicio INT IDENTITY,
    tipo_servicio varchar(20),
    precio_servicio SMALLMONEY,
    id_plan varchar(20),
    CONSTRAINT fk_id_plan FOREIGN KEY (id_plan) REFERENCES planes(id_plan),
    PRIMARY KEY(id_servicio)
  );
GO

INSERT INTO servicios VALUES('STANDAR',40,'PLAN1');
INSERT INTO servicios VALUES('STANDAR',50,'PLAN2');
INSERT INTO servicios VALUES('STANDAR',40,'PLANI1');
INSERT INTO servicios VALUES('STANDAR',50,'PLANI2');
INSERT INTO servicios VALUES('STANDAR',60,'PLANI3');
INSERT INTO servicios VALUES('DUO',50,'DUO1');
INSERT INTO servicios VALUES('DUO',70,'DUO2');
INSERT INTO servicios VALUES('DUO',90,'DUO3');

  CREATE TABLE cliente_servicio(
    id_cliente_servicio INT IDENTITY,
    fecha_instalacion date,
    pago_instalacion SMALLMONEY,
    id_cliente VARCHAR(8) ,
    CONSTRAINT fk_id_cli1 FOREIGN KEY(id_cliente) REFERENCES clientes(id_cliente),
    id_servicio INT,
    CONSTRAINT fk_id_ser FOREIGN KEY(id_servicio) REFERENCES servicios(id_servicio),
    cod_empleado INT,
    CONSTRAINT fk_cod_empl FOREIGN KEY(cod_empleado) REFERENCES empleados(cod_empleado),
    PRIMARY KEY(id_cliente_servicio)
  );
  GO
  INSERT INTO cliente_servicio VALUES('05/11/2019',40.00,'70889470',1,1);
  INSERT INTO cliente_servicio VALUES('03/10/2019',40.00,'10012164',7,2);
    
    CREATE TABLE pago_mensual(
    id_pago_mensual int IDENTITY,
    estado_pago VARCHAR(20),
    fecha_pago date,
    fecha_pagada date,
    pago_mensual SMALLMONEY,
    id_cliente_servicio int,
    CONSTRAINT fk_cli_servi1 FOREIGN KEY(id_cliente_servicio) REFERENCES cliente_servicio(id_cliente_servicio),
    PRIMARY KEY(id_cliente_servicio)
  );
  INSERT INTO pago_mensual VALUES('PAGO','05/12/2019','05/12/2019',40.00,1);
  INSERT INTO pago_mensual VALUES('PAGO','03/11/2019','03/11/2019',70.00,2);
GO