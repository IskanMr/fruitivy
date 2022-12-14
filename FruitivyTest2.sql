PGDMP     )    2    
        
    z            FruitivyTest2    14.5    14.5 _    i           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            j           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            k           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            l           1262    28663    FruitivyTest2    DATABASE     s   CREATE DATABASE "FruitivyTest2" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
    DROP DATABASE "FruitivyTest2";
                postgres    false                       1255    33843 H   checkout(integer, character varying, integer, integer, integer, integer)    FUNCTION     D  CREATE FUNCTION public.checkout(_keranjangid integer, _pesan character varying, _pembayaranid integer, _pengirimanid integer, _ongkir integer, _penggunaid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
	_newtransaksiid int;
	_step2 int;
	_step3 int;
	_step4 int;
begin
	_newtransaksiid = transaksi_c
		(
		_pesan, 
		_pembayaranid, 
		_pengirimanid, 
		_ongkir, 
		_penggunaid
		);
		
	_step2 = transaksidetail_c
	(
	_keranjangid, 
	_newtransaksiid
	);
	
	_step3 = transaksi_u(_newtransaksiid);
	
	_step4 = keranjangall_d(_keranjangid);
	
	return _step4;
end
$$;
 ?   DROP FUNCTION public.checkout(_keranjangid integer, _pesan character varying, _pembayaranid integer, _pengirimanid integer, _ongkir integer, _penggunaid integer);
       public          postgres    false            ?            1255    28795    keranjang_c_pengguna(integer)    FUNCTION       CREATE FUNCTION public.keranjang_c_pengguna(_penggunaid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	INSERT INTO public.keranjang(
	"TotalHarga", "PenggunaId")
	VALUES ( 0, _penggunaid);
	
	if found then 
		return 1;
	else 
		return 0;
	end if;
	
end
$$;
 @   DROP FUNCTION public.keranjang_c_pengguna(_penggunaid integer);
       public          postgres    false            ?            1255    28809    keranjang_d(integer)    FUNCTION     ?   CREATE FUNCTION public.keranjang_d(_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	DELETE FROM public.keranjang
	WHERE "Id"= _id;
	if found then
		return 1;
	else 
		return 0;
	end if;
	
end
$$;
 /   DROP FUNCTION public.keranjang_d(_id integer);
       public          postgres    false            ?            1255    28797 &   keranjang_u_pengguna(integer, integer)    FUNCTION       CREATE FUNCTION public.keranjang_u_pengguna(_id integer, _totalharga integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	UPDATE public.keranjang
	SET "TotalHarga"=_totalharga
	WHERE "Id" = _id;
		
	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 M   DROP FUNCTION public.keranjang_u_pengguna(_id integer, _totalharga integer);
       public          postgres    false                        1255    33617    keranjangall_d(integer)    FUNCTION       CREATE FUNCTION public.keranjangall_d(_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	DELETE FROM public."keranjangdetail"
	WHERE "KeranjangId"=_id;
	
	DELETE FROM public."keranjang"
	WHERE "Id" = _id;
	
	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 2   DROP FUNCTION public.keranjangall_d(_id integer);
       public          postgres    false            ?            1255    28796 >   keranjangdetail_c_pengguna(integer, integer, integer, integer)    FUNCTION     ?  CREATE FUNCTION public.keranjangdetail_c_pengguna(_harga integer, _jumlah integer, _keranjangid integer, _produkid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	INSERT INTO public.keranjangdetail(
	"Harga", "Subtotal", "Jumlah", "KeranjangId", "ProdukId")
	VALUES (_harga, (_harga * _jumlah), _jumlah, _keranjangid, _produkid);
	
	if found then 
		return 1;
	else 
		return 0;
	end if;
	
end
$$;
 {   DROP FUNCTION public.keranjangdetail_c_pengguna(_harga integer, _jumlah integer, _keranjangid integer, _produkid integer);
       public          postgres    false            ?            1255    28799    keranjangdetail_d(integer)    FUNCTION     ?   CREATE FUNCTION public.keranjangdetail_d(_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	DELETE FROM public.keranjangdetail
	WHERE "Id" = _id;
	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 5   DROP FUNCTION public.keranjangdetail_d(_id integer);
       public          postgres    false            ?            1255    28798 ,   keranjangdetail_u_pengguna(integer, integer)    FUNCTION     0  CREATE FUNCTION public.keranjangdetail_u_pengguna(_id integer, _jumlah integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	UPDATE public.keranjangdetail
	SET  "Subtotal"=("Harga" * _jumlah), "Jumlah"=_jumlah
	WHERE "Id" = _id;
		
	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 O   DROP FUNCTION public.keranjangdetail_u_pengguna(_id integer, _jumlah integer);
       public          postgres    false            ?            1255    33579 S   pengguna_c_signup(character varying, character varying, character varying, integer)    FUNCTION     ?  CREATE FUNCTION public.pengguna_c_signup(_username character varying, _password character varying, _email character varying, _roleid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into public.pengguna
	(
		"Username",
		"Password",
		"Email",
		"RoleId"
	)
	values
	(
		_username, 
		_password,
		_email,
		_roleid
	);
	if found then 
		return 1;
	else 
		return 0;
	end if;
	
end
$$;
 ?   DROP FUNCTION public.pengguna_c_signup(_username character varying, _password character varying, _email character varying, _roleid integer);
       public          postgres    false            ?            1255    33582 ,   pengguna_r_forgetpassword(character varying)    FUNCTION     ,  CREATE FUNCTION public.pengguna_r_forgetpassword(_email character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	
	PERFORM "Id", "Username", "Password", "Email", "RoleId"
	FROM public.pengguna
	WHERE "Email" = _email;
	
	if found then 
		return 1;
	else 
		return 0;
	end if;
end
$$;
 J   DROP FUNCTION public.pengguna_r_forgetpassword(_email character varying);
       public          postgres    false                       1255    33888 ?   pengguna_r_login(character varying, character varying, integer)    FUNCTION     ?  CREATE FUNCTION public.pengguna_r_login(_username character varying, _password character varying, _roleid integer) RETURNS TABLE(_id integer)
    LANGUAGE plpgsql
    AS $$
begin
 return query
 SELECT "Id"
 FROM public.pengguna
 WHERE "Username" = _username
 AND "Password" = _password
 AND "RoleId" = _roleid;
end
$$;
 r   DROP FUNCTION public.pengguna_r_login(_username character varying, _password character varying, _roleid integer);
       public          postgres    false            ?            1255    33584 ?   pengguna_u_forgetpassword(character varying, character varying)    FUNCTION     0  CREATE FUNCTION public.pengguna_u_forgetpassword(_email character varying, _password character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	UPDATE public."pengguna"
	SET
		"Password"=_password
	WHERE
		"Email" = _email;
		
	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 g   DROP FUNCTION public.pengguna_u_forgetpassword(_email character varying, _password character varying);
       public          postgres    false            ?            1255    33585 I   produk_c_pengguna(character varying, integer, character varying, integer)    FUNCTION     ?  CREATE FUNCTION public.produk_c_pengguna(_nama character varying, _harga integer, _deskripsi character varying, _penggunaid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into public."produk"
	(
		"Nama",
		"Harga",
		"Deskripsi",
		"PenggunaId"
	)
	values
	(
		_nama, 
		_harga,
		_deskripsi,
		_penggunaid
	);
	if found then 
		return 1;
	else 
		return 0;
	end if;
	
end
$$;
 ?   DROP FUNCTION public.produk_c_pengguna(_nama character varying, _harga integer, _deskripsi character varying, _penggunaid integer);
       public          postgres    false            ?            1255    33587    produk_d_pengguna(integer)    FUNCTION     ?   CREATE FUNCTION public.produk_d_pengguna(_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	DELETE FROM public."produk"
	WHERE "Id"=_id;
	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 5   DROP FUNCTION public.produk_d_pengguna(_id integer);
       public          postgres    false            ?            1255    33591    produk_r_pembeli()    FUNCTION     ?   CREATE FUNCTION public.produk_r_pembeli() RETURNS TABLE(_id integer, _nama text, _harga integer, _deskripsi text)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT "Id", "Nama", "Harga", "Deskripsi"
	FROM public."produk";
end
$$;
 )   DROP FUNCTION public.produk_r_pembeli();
       public          postgres    false            ?            1255    33606    produk_r_penjual(integer)    FUNCTION     %  CREATE FUNCTION public.produk_r_penjual(_penggunaid integer) RETURNS TABLE(_id integer, _nama text, _harga integer, _deskripsi text)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT "Id", "Nama", "Harga", "Deskripsi"
	FROM public."produk"
	WHERE
	"PenggunaId" = _penggunaid;
end
$$;
 <   DROP FUNCTION public.produk_r_penjual(_penggunaid integer);
       public          postgres    false            ?            1255    33608    produk_r_produkid(integer)    FUNCTION     ?   CREATE FUNCTION public.produk_r_produkid(_id integer) RETURNS TABLE(_nama text, _harga integer, _deskripsi text)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT "Nama", "Harga", "Deskripsi"
	FROM public."produk"
	WHERE
	"Id" = _id;
end
$$;
 5   DROP FUNCTION public.produk_r_produkid(_id integer);
       public          postgres    false            ?            1255    33602    produk_r_termurah()    FUNCTION     )  CREATE FUNCTION public.produk_r_termurah() RETURNS TABLE(_id integer, _nama text, _harga integer, _deskripsi text, _penggunaid integer)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT "Id", "Nama", "Harga", "Deskripsi", "PenggunaId"
	FROM public."produk"
	ORDER BY "Harga" ASC;
end
$$;
 *   DROP FUNCTION public.produk_r_termurah();
       public          postgres    false            ?            1255    33586 I   produk_u_pengguna(character varying, integer, character varying, integer)    FUNCTION     `  CREATE FUNCTION public.produk_u_pengguna(_nama character varying, _harga integer, _deskripsi character varying, _id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	UPDATE public."produk"
	SET
		"Nama"=_nama,
		"Harga"=_harga,
		"Deskripsi"=_deskripsi
	WHERE
		"Id"= _id;
		
	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 |   DROP FUNCTION public.produk_u_pengguna(_nama character varying, _harga integer, _deskripsi character varying, _id integer);
       public          postgres    false                       1255    33839 B   transaksi_c(character varying, integer, integer, integer, integer)    FUNCTION     ?  CREATE FUNCTION public.transaksi_c(_pesan character varying, _pembayaranid integer, _pengirimanid integer, _ongkir integer, _penggunaid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
	_newid int;
begin

	INSERT INTO public.transaksi
	(
	 "TotalTagihan", "Pesan", "PembayaranId", "PengirimanId", "Ongkir", "TotalHarga", "PenggunaId"
	)
	VALUES
	(_ongkir, _pesan,_pembayaranid,_pengirimanid,_ongkir,0, _penggunaid)
	returning "Id" into _newid;
	return _newid;
	
end
$$;
 ?   DROP FUNCTION public.transaksi_c(_pesan character varying, _pembayaranid integer, _pengirimanid integer, _ongkir integer, _penggunaid integer);
       public          postgres    false            ?            1255    33612    transaksi_r_pengguna(integer)    FUNCTION     ?   CREATE FUNCTION public.transaksi_r_pengguna(_penggunaid integer) RETURNS TABLE(_totaltagihan integer)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT "TotalTagihan"
	FROM public."transaksi"
	WHERE
	"PenggunaId" = _penggunaid;
end
$$;
 @   DROP FUNCTION public.transaksi_r_pengguna(_penggunaid integer);
       public          postgres    false                       1255    33836    transaksi_u(integer)    FUNCTION     ?  CREATE FUNCTION public.transaksi_u(_transaksiid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE _totalharga int = 
	(
		SELECT sum("Subtotal")
		FROM public.transaksidetail
		WHERE "TransaksiId" = _transaksiid
	);
begin
	UPDATE public.transaksi
	SET
		"TotalTagihan"=(_totalharga + "Ongkir"),
		"TotalHarga"=_totalharga
	WHERE "Id" = _transaksiid;
	
	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 8   DROP FUNCTION public.transaksi_u(_transaksiid integer);
       public          postgres    false                       1255    33831 #   transaksidetail_c(integer, integer)    FUNCTION     ?  CREATE FUNCTION public.transaksidetail_c(_keranjangid integer, _transaksiid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
INSERT INTO public.transaksidetail(
	"Harga", "Subtotal", "Jumlah", "TransaksiId", "ProdukId")
SELECT "Harga", "Subtotal", "Jumlah", _transaksiid as "TransaksiId",  "ProdukId"
FROM public.keranjangdetail
WHERE "KeranjangId" = _keranjangid;

if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 T   DROP FUNCTION public.transaksidetail_c(_keranjangid integer, _transaksiid integer);
       public          postgres    false            ?            1259    28664    __EFMigrationsHistory    TABLE     ?   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    postgres    false            ?            1259    28707 	   keranjang    TABLE     ?   CREATE TABLE public.keranjang (
    "Id" integer NOT NULL,
    "TotalHarga" integer NOT NULL,
    "PenggunaId" integer NOT NULL
);
    DROP TABLE public.keranjang;
       public         heap    postgres    false            ?            1259    28706    keranjang_Id_seq    SEQUENCE     ?   ALTER TABLE public.keranjang ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."keranjang_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    219            ?            1259    28754    keranjangdetail    TABLE     ?   CREATE TABLE public.keranjangdetail (
    "Id" integer NOT NULL,
    "Harga" integer NOT NULL,
    "Subtotal" integer NOT NULL,
    "Jumlah" integer NOT NULL,
    "KeranjangId" integer NOT NULL,
    "ProdukId" integer NOT NULL
);
 #   DROP TABLE public.keranjangdetail;
       public         heap    postgres    false            ?            1259    28753    keranjangdetail_Id_seq    SEQUENCE     ?   ALTER TABLE public.keranjangdetail ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."keranjangdetail_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    225            ?            1259    28670 
   pembayaran    TABLE     X   CREATE TABLE public.pembayaran (
    "Id" integer NOT NULL,
    "Nama" text NOT NULL
);
    DROP TABLE public.pembayaran;
       public         heap    postgres    false            ?            1259    28669    pembayaran_Id_seq    SEQUENCE     ?   ALTER TABLE public.pembayaran ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."pembayaran_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    211            ?            1259    28694    pengguna    TABLE     ?   CREATE TABLE public.pengguna (
    "Id" integer NOT NULL,
    "Username" text NOT NULL,
    "Password" text NOT NULL,
    "Email" text NOT NULL,
    "RoleId" integer NOT NULL
);
    DROP TABLE public.pengguna;
       public         heap    postgres    false            ?            1259    28693    pengguna_Id_seq    SEQUENCE     ?   ALTER TABLE public.pengguna ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."pengguna_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    217            ?            1259    28678 
   pengiriman    TABLE     X   CREATE TABLE public.pengiriman (
    "Id" integer NOT NULL,
    "Nama" text NOT NULL
);
    DROP TABLE public.pengiriman;
       public         heap    postgres    false            ?            1259    28677    pengiriman_Id_seq    SEQUENCE     ?   ALTER TABLE public.pengiriman ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."pengiriman_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    213            ?            1259    28718    produk    TABLE     ?   CREATE TABLE public.produk (
    "Id" integer NOT NULL,
    "Nama" text NOT NULL,
    "Harga" integer NOT NULL,
    "Deskripsi" text NOT NULL,
    "PenggunaId" integer NOT NULL
);
    DROP TABLE public.produk;
       public         heap    postgres    false            ?            1259    28717    produk_Id_seq    SEQUENCE     ?   ALTER TABLE public.produk ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."produk_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    221            ?            1259    28686    role    TABLE     R   CREATE TABLE public.role (
    "Id" integer NOT NULL,
    "Name" text NOT NULL
);
    DROP TABLE public.role;
       public         heap    postgres    false            ?            1259    28685    role_Id_seq    SEQUENCE     ?   ALTER TABLE public.role ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."role_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    215            ?            1259    28731 	   transaksi    TABLE     @  CREATE TABLE public.transaksi (
    "Id" integer NOT NULL,
    "TotalTagihan" integer NOT NULL,
    "Pesan" text NOT NULL,
    "PenggunaId" integer NOT NULL,
    "PembayaranId" integer NOT NULL,
    "PengirimanId" integer NOT NULL,
    "Ongkir" integer DEFAULT 0 NOT NULL,
    "TotalHarga" integer DEFAULT 0 NOT NULL
);
    DROP TABLE public.transaksi;
       public         heap    postgres    false            ?            1259    28730    transaksi_Id_seq    SEQUENCE     ?   ALTER TABLE public.transaksi ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."transaksi_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    223            ?            1259    28770    transaksidetail    TABLE     ?   CREATE TABLE public.transaksidetail (
    "Id" integer NOT NULL,
    "Harga" integer NOT NULL,
    "Subtotal" integer NOT NULL,
    "Jumlah" integer NOT NULL,
    "TransaksiId" integer NOT NULL,
    "ProdukId" integer NOT NULL
);
 #   DROP TABLE public.transaksidetail;
       public         heap    postgres    false            ?            1259    28769    transaksidetail_Id_seq    SEQUENCE     ?   ALTER TABLE public.transaksidetail ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."transaksidetail_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    227            T          0    28664    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    209   o?       ^          0    28707 	   keranjang 
   TABLE DATA           E   COPY public.keranjang ("Id", "TotalHarga", "PenggunaId") FROM stdin;
    public          postgres    false    219   ؋       d          0    28754    keranjangdetail 
   TABLE DATA           i   COPY public.keranjangdetail ("Id", "Harga", "Subtotal", "Jumlah", "KeranjangId", "ProdukId") FROM stdin;
    public          postgres    false    225   ?       V          0    28670 
   pembayaran 
   TABLE DATA           2   COPY public.pembayaran ("Id", "Nama") FROM stdin;
    public          postgres    false    211   >?       \          0    28694    pengguna 
   TABLE DATA           S   COPY public.pengguna ("Id", "Username", "Password", "Email", "RoleId") FROM stdin;
    public          postgres    false    217   y?       X          0    28678 
   pengiriman 
   TABLE DATA           2   COPY public.pengiriman ("Id", "Nama") FROM stdin;
    public          postgres    false    213   ??       `          0    28718    produk 
   TABLE DATA           R   COPY public.produk ("Id", "Nama", "Harga", "Deskripsi", "PenggunaId") FROM stdin;
    public          postgres    false    221   !?       Z          0    28686    role 
   TABLE DATA           ,   COPY public.role ("Id", "Name") FROM stdin;
    public          postgres    false    215   ׍       b          0    28731 	   transaksi 
   TABLE DATA           ?   COPY public.transaksi ("Id", "TotalTagihan", "Pesan", "PenggunaId", "PembayaranId", "PengirimanId", "Ongkir", "TotalHarga") FROM stdin;
    public          postgres    false    223   ?       f          0    28770    transaksidetail 
   TABLE DATA           i   COPY public.transaksidetail ("Id", "Harga", "Subtotal", "Jumlah", "TransaksiId", "ProdukId") FROM stdin;
    public          postgres    false    227   ??       m           0    0    keranjang_Id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."keranjang_Id_seq"', 6, true);
          public          postgres    false    218            n           0    0    keranjangdetail_Id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."keranjangdetail_Id_seq"', 9, true);
          public          postgres    false    224            o           0    0    pembayaran_Id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."pembayaran_Id_seq"', 4, false);
          public          postgres    false    210            p           0    0    pengguna_Id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."pengguna_Id_seq"', 6, true);
          public          postgres    false    216            q           0    0    pengiriman_Id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."pengiriman_Id_seq"', 4, false);
          public          postgres    false    212            r           0    0    produk_Id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public."produk_Id_seq"', 7, true);
          public          postgres    false    220            s           0    0    role_Id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."role_Id_seq"', 3, false);
          public          postgres    false    214            t           0    0    transaksi_Id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."transaksi_Id_seq"', 15, true);
          public          postgres    false    222            u           0    0    transaksidetail_Id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."transaksidetail_Id_seq"', 8, true);
          public          postgres    false    226            ?           2606    28668 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            postgres    false    209            ?           2606    28711    keranjang PK_keranjang 
   CONSTRAINT     X   ALTER TABLE ONLY public.keranjang
    ADD CONSTRAINT "PK_keranjang" PRIMARY KEY ("Id");
 B   ALTER TABLE ONLY public.keranjang DROP CONSTRAINT "PK_keranjang";
       public            postgres    false    219            ?           2606    28758 "   keranjangdetail PK_keranjangdetail 
   CONSTRAINT     d   ALTER TABLE ONLY public.keranjangdetail
    ADD CONSTRAINT "PK_keranjangdetail" PRIMARY KEY ("Id");
 N   ALTER TABLE ONLY public.keranjangdetail DROP CONSTRAINT "PK_keranjangdetail";
       public            postgres    false    225            ?           2606    28676    pembayaran PK_pembayaran 
   CONSTRAINT     Z   ALTER TABLE ONLY public.pembayaran
    ADD CONSTRAINT "PK_pembayaran" PRIMARY KEY ("Id");
 D   ALTER TABLE ONLY public.pembayaran DROP CONSTRAINT "PK_pembayaran";
       public            postgres    false    211            ?           2606    28700    pengguna PK_pengguna 
   CONSTRAINT     V   ALTER TABLE ONLY public.pengguna
    ADD CONSTRAINT "PK_pengguna" PRIMARY KEY ("Id");
 @   ALTER TABLE ONLY public.pengguna DROP CONSTRAINT "PK_pengguna";
       public            postgres    false    217            ?           2606    28684    pengiriman PK_pengiriman 
   CONSTRAINT     Z   ALTER TABLE ONLY public.pengiriman
    ADD CONSTRAINT "PK_pengiriman" PRIMARY KEY ("Id");
 D   ALTER TABLE ONLY public.pengiriman DROP CONSTRAINT "PK_pengiriman";
       public            postgres    false    213            ?           2606    28724    produk PK_produk 
   CONSTRAINT     R   ALTER TABLE ONLY public.produk
    ADD CONSTRAINT "PK_produk" PRIMARY KEY ("Id");
 <   ALTER TABLE ONLY public.produk DROP CONSTRAINT "PK_produk";
       public            postgres    false    221            ?           2606    28692    role PK_role 
   CONSTRAINT     N   ALTER TABLE ONLY public.role
    ADD CONSTRAINT "PK_role" PRIMARY KEY ("Id");
 8   ALTER TABLE ONLY public.role DROP CONSTRAINT "PK_role";
       public            postgres    false    215            ?           2606    28737    transaksi PK_transaksi 
   CONSTRAINT     X   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT "PK_transaksi" PRIMARY KEY ("Id");
 B   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT "PK_transaksi";
       public            postgres    false    223            ?           2606    28774 "   transaksidetail PK_transaksidetail 
   CONSTRAINT     d   ALTER TABLE ONLY public.transaksidetail
    ADD CONSTRAINT "PK_transaksidetail" PRIMARY KEY ("Id");
 N   ALTER TABLE ONLY public.transaksidetail DROP CONSTRAINT "PK_transaksidetail";
       public            postgres    false    227            ?           1259    28785    IX_keranjang_PenggunaId    INDEX     W   CREATE INDEX "IX_keranjang_PenggunaId" ON public.keranjang USING btree ("PenggunaId");
 -   DROP INDEX public."IX_keranjang_PenggunaId";
       public            postgres    false    219            ?           1259    28786    IX_keranjangdetail_KeranjangId    INDEX     e   CREATE INDEX "IX_keranjangdetail_KeranjangId" ON public.keranjangdetail USING btree ("KeranjangId");
 4   DROP INDEX public."IX_keranjangdetail_KeranjangId";
       public            postgres    false    225            ?           1259    28787    IX_keranjangdetail_ProdukId    INDEX     _   CREATE INDEX "IX_keranjangdetail_ProdukId" ON public.keranjangdetail USING btree ("ProdukId");
 1   DROP INDEX public."IX_keranjangdetail_ProdukId";
       public            postgres    false    225            ?           1259    28788    IX_pengguna_RoleId    INDEX     M   CREATE INDEX "IX_pengguna_RoleId" ON public.pengguna USING btree ("RoleId");
 (   DROP INDEX public."IX_pengguna_RoleId";
       public            postgres    false    217            ?           1259    28789    IX_produk_PenggunaId    INDEX     Q   CREATE INDEX "IX_produk_PenggunaId" ON public.produk USING btree ("PenggunaId");
 *   DROP INDEX public."IX_produk_PenggunaId";
       public            postgres    false    221            ?           1259    28790    IX_transaksi_PembayaranId    INDEX     [   CREATE INDEX "IX_transaksi_PembayaranId" ON public.transaksi USING btree ("PembayaranId");
 /   DROP INDEX public."IX_transaksi_PembayaranId";
       public            postgres    false    223            ?           1259    28791    IX_transaksi_PenggunaId    INDEX     W   CREATE INDEX "IX_transaksi_PenggunaId" ON public.transaksi USING btree ("PenggunaId");
 -   DROP INDEX public."IX_transaksi_PenggunaId";
       public            postgres    false    223            ?           1259    28792    IX_transaksi_PengirimanId    INDEX     [   CREATE INDEX "IX_transaksi_PengirimanId" ON public.transaksi USING btree ("PengirimanId");
 /   DROP INDEX public."IX_transaksi_PengirimanId";
       public            postgres    false    223            ?           1259    28793    IX_transaksidetail_ProdukId    INDEX     _   CREATE INDEX "IX_transaksidetail_ProdukId" ON public.transaksidetail USING btree ("ProdukId");
 1   DROP INDEX public."IX_transaksidetail_ProdukId";
       public            postgres    false    227            ?           1259    28794    IX_transaksidetail_TransaksiId    INDEX     e   CREATE INDEX "IX_transaksidetail_TransaksiId" ON public.transaksidetail USING btree ("TransaksiId");
 4   DROP INDEX public."IX_transaksidetail_TransaksiId";
       public            postgres    false    227            ?           2606    28712 *   keranjang FK_keranjang_pengguna_PenggunaId    FK CONSTRAINT     ?   ALTER TABLE ONLY public.keranjang
    ADD CONSTRAINT "FK_keranjang_pengguna_PenggunaId" FOREIGN KEY ("PenggunaId") REFERENCES public.pengguna("Id") ON DELETE CASCADE;
 V   ALTER TABLE ONLY public.keranjang DROP CONSTRAINT "FK_keranjang_pengguna_PenggunaId";
       public          postgres    false    3243    217    219            ?           2606    28759 8   keranjangdetail FK_keranjangdetail_keranjang_KeranjangId    FK CONSTRAINT     ?   ALTER TABLE ONLY public.keranjangdetail
    ADD CONSTRAINT "FK_keranjangdetail_keranjang_KeranjangId" FOREIGN KEY ("KeranjangId") REFERENCES public.keranjang("Id") ON DELETE CASCADE;
 d   ALTER TABLE ONLY public.keranjangdetail DROP CONSTRAINT "FK_keranjangdetail_keranjang_KeranjangId";
       public          postgres    false    3246    219    225            ?           2606    28764 2   keranjangdetail FK_keranjangdetail_produk_ProdukId    FK CONSTRAINT     ?   ALTER TABLE ONLY public.keranjangdetail
    ADD CONSTRAINT "FK_keranjangdetail_produk_ProdukId" FOREIGN KEY ("ProdukId") REFERENCES public.produk("Id") ON DELETE CASCADE;
 ^   ALTER TABLE ONLY public.keranjangdetail DROP CONSTRAINT "FK_keranjangdetail_produk_ProdukId";
       public          postgres    false    221    3249    225            ?           2606    28701     pengguna FK_pengguna_role_RoleId    FK CONSTRAINT     ?   ALTER TABLE ONLY public.pengguna
    ADD CONSTRAINT "FK_pengguna_role_RoleId" FOREIGN KEY ("RoleId") REFERENCES public.role("Id") ON DELETE CASCADE;
 L   ALTER TABLE ONLY public.pengguna DROP CONSTRAINT "FK_pengguna_role_RoleId";
       public          postgres    false    3240    215    217            ?           2606    28725 $   produk FK_produk_pengguna_PenggunaId    FK CONSTRAINT     ?   ALTER TABLE ONLY public.produk
    ADD CONSTRAINT "FK_produk_pengguna_PenggunaId" FOREIGN KEY ("PenggunaId") REFERENCES public.pengguna("Id") ON DELETE CASCADE;
 P   ALTER TABLE ONLY public.produk DROP CONSTRAINT "FK_produk_pengguna_PenggunaId";
       public          postgres    false    3243    221    217            ?           2606    28738 .   transaksi FK_transaksi_pembayaran_PembayaranId    FK CONSTRAINT     ?   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT "FK_transaksi_pembayaran_PembayaranId" FOREIGN KEY ("PembayaranId") REFERENCES public.pembayaran("Id") ON DELETE CASCADE;
 Z   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT "FK_transaksi_pembayaran_PembayaranId";
       public          postgres    false    223    211    3236            ?           2606    28743 *   transaksi FK_transaksi_pengguna_PenggunaId    FK CONSTRAINT     ?   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT "FK_transaksi_pengguna_PenggunaId" FOREIGN KEY ("PenggunaId") REFERENCES public.pengguna("Id") ON DELETE CASCADE;
 V   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT "FK_transaksi_pengguna_PenggunaId";
       public          postgres    false    217    3243    223            ?           2606    28748 .   transaksi FK_transaksi_pengiriman_PengirimanId    FK CONSTRAINT     ?   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT "FK_transaksi_pengiriman_PengirimanId" FOREIGN KEY ("PengirimanId") REFERENCES public.pengiriman("Id") ON DELETE CASCADE;
 Z   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT "FK_transaksi_pengiriman_PengirimanId";
       public          postgres    false    223    213    3238            ?           2606    28775 2   transaksidetail FK_transaksidetail_produk_ProdukId    FK CONSTRAINT     ?   ALTER TABLE ONLY public.transaksidetail
    ADD CONSTRAINT "FK_transaksidetail_produk_ProdukId" FOREIGN KEY ("ProdukId") REFERENCES public.produk("Id") ON DELETE CASCADE;
 ^   ALTER TABLE ONLY public.transaksidetail DROP CONSTRAINT "FK_transaksidetail_produk_ProdukId";
       public          postgres    false    221    3249    227            ?           2606    28780 8   transaksidetail FK_transaksidetail_transaksi_TransaksiId    FK CONSTRAINT     ?   ALTER TABLE ONLY public.transaksidetail
    ADD CONSTRAINT "FK_transaksidetail_transaksi_TransaksiId" FOREIGN KEY ("TransaksiId") REFERENCES public.transaksi("Id") ON DELETE CASCADE;
 d   ALTER TABLE ONLY public.transaksidetail DROP CONSTRAINT "FK_transaksidetail_transaksi_TransaksiId";
       public          postgres    false    227    223    3254            T   Y   x?e?M
? @?us?¼K #????ޟ?????}??D???????b~???
y???Tr?]??2?ω?1|?M=?I_? ?  ?      ^      x?3?46 Nc.SN???? !??      d   -   x?3?44 Nc	?\f?&`?4?4?4?2?"f?!f????? ?Y      V   +   x?3?tJ??V)J?+NK-?2?t?w?2???,)J?????? ??	,      \   ]   x?U?A
?0??c
IS{?!^??????m?6?,$^?w5?????q??j?I?}??	.??u!?St??2\?`??\A/??K$?J=v      X   +   x?3?t/JL?2?t?/N?K?2???sUp?((J-.?????? ?:	;      `   ?   x?m??
?@???S????:W]??[t?p?uuu߾E%/???ǌ??{?I?B?΁?L?????XOG???@?X??(?֠W?g?d??????}|Iw?`z?e??L?pߚ?r?9?<t??d7????d?/??V ???;??N?
8?x?7????c??_s?Kl      Z      x?3?H?MJ???2???Js?b???? _?      b   ?   x????
?0???S??i????a?]"-?? ???????(??6??K?Bk-\Wn?????&?x8????I??i????? P?%V?ꂀo? ?a??}???}?n??/<gK=U?5??P?B???H?ŖP??? ?#?KJ?$*?~??
}?9????1/q?cv      f   C   x?3?44 	?\FP??A.c??1?A.S,bf???`]f??Ɯf\???&@AtAS?`? U?     