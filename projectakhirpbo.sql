-- Tabel Utama
CREATE TABLE pengguna (
  id_pengguna SERIAL PRIMARY KEY,
  nama VARCHAR(100) NOT NULL,
  email VARCHAR(100) UNIQUE NOT NULL,
  no_telepon VARCHAR(20),
  password VARCHAR(100) NOT NULL
);

CREATE TABLE fotografer (
  id_fotografer SERIAL PRIMARY KEY,
  nama VARCHAR(100) NOT NULL,
  email VARCHAR(100) UNIQUE NOT NULL,
  no_telepon VARCHAR(20) NOT NULL
);

CREATE TABLE jenis_layanan (
  id_jenis_layanan SERIAL PRIMARY KEY,
  nama_jenis VARCHAR(100) NOT NULL
);

CREATE TABLE paket_jasa (
  id_paket_jasa SERIAL PRIMARY KEY,
  nama_paket VARCHAR(100) NOT NULL,
  harga INT NOT NULL,
  deskripsi TEXT,
  id_jenis_layanan INT,
  FOREIGN KEY (id_jenis_layanan) REFERENCES jenis_layanan(id_jenis_layanan)
);

CREATE TABLE status_booking (
  id_status_booking SERIAL PRIMARY KEY,
  status VARCHAR(50) NOT NULL
);

CREATE TABLE metode_pembayaran (
  id_metode_pembayaran SERIAL PRIMARY KEY,
  metode_pembayaran VARCHAR(50) NOT NULL
);

CREATE TABLE pembayaran (
  id_pembayaran SERIAL PRIMARY KEY,
  total_harga INT NOT NULL,
  tanggal_pembayaran DATE NOT NULL,
  id_metode_pembayaran INT NOT NULL,
  id_booking INT NOT NULL,
  FOREIGN KEY (id_metode_pembayaran) REFERENCES metode_pembayaran(id_metode_pembayaran)
  -- id_booking bisa jadi nullable jika belum diketahui saat create
);


-- BOOKING harus diletakkan setelah semua referensi (paket_jasa, pengguna, fotografer, dst)
CREATE TABLE booking (
  id_booking SERIAL PRIMARY KEY,
  tanggal_booking DATE NOT NULL,
  tanggal_pelaksanaan DATE,
  waktu_mulai TIME,
  waktu_selesai TIME,
  tempat VARCHAR(255),
  catatan TEXT,
  id_pengguna INT NOT NULL,
  id_fotografer INT,
  id_status_booking INT NOT NULL,
  id_paket_jasa INT,
  FOREIGN KEY (id_pengguna) REFERENCES pengguna(id_pengguna),
  FOREIGN KEY (id_fotografer) REFERENCES fotografer(id_fotografer),
  FOREIGN KEY (id_status_booking) REFERENCES status_booking(id_status_booking),
  FOREIGN KEY (id_paket_jasa) REFERENCES paket_jasa(id_paket_jasa),
);

CREATE TABLE review (
  id_review SERIAL PRIMARY KEY,
  rating INT NOT NULL CHECK (rating >= 1 AND rating <= 5),
  komentar TEXT,
  tanggal_review DATE NOT NULL,
  id_booking INT NOT NULL,
  FOREIGN KEY (id_booking) REFERENCES booking(id_booking)
);

-- PENAMBAHAN DATA AWAL
INSERT INTO jenis_layanan (nama_jenis) VALUES 
  ('Fotografi'), 
  ('Videografi'), 
  ('Desain'),
  ('Fotografi + Videografi');

INSERT INTO status_booking (status) VALUES 
  ('Pending'), 
  ('Disetujui'), 
  ('Dibatalkan'), 
  ('Selesai');

INSERT INTO metode_pembayaran (metode_pembayaran) VALUES 
  ('Tunai'), 
  ('Transfer Bank'), 
  ('Kartu Kredit');

INSERT INTO paket_jasa (nama_paket, harga, deskripsi, id_jenis_layanan) VALUES
  ('Paket Wisuda (2 Jam)', 500000, 'Foto + edit basic, durasi ± 1 jam, 1 fotografer', 1),
  ('Paket Wedding (12 jam)', 7000000, 'Full day, 2 fotografer + 1 videografer, album + video highlight', 4),
  ('Paket Lamaran (5 jam)', 3500000, '1–3 jam, dokumentasi foto & video, 1 fotografer + 1 videografer', 4),
  ('Paket Event (5 jam)', 3500000, '1–3 jam, dokumentasi foto & video, 1 fotografer + 1 videografer', 4),
  ('Paket Corporate (12 jam)', 6000000, 'Video profil perusahaan + sesi foto, termasuk voice over & editing', 4),
  ('Paket Product Photo & Video (5 jam)', 300000, 'Termasuk editing, background studio, atau lifestyle shoot', 3),
  ('Paket Desain Logo', 500000, 'Termasuk revisi & file master (AI/PSD/SVG), brand mockup', 3),
  ('Paket Desain Promosi', 400000, 'Desain statis (untuk cetak/digital), 2–3 kali revisi', 3),
  ('Paket Desain Kemasan', 500000, 'Label botol, box, pouch, termasuk file siap cetak dan preview mockup', 3);


select * from pengguna
select * from fotografer
select * from jenis_layanan
select * from paket_jasa
select * from status_booking
select * from booking
select * from metode_pembayaran
select * from pembayaran
select * from review

TRUNCATE TABLE pengguna RESTART IDENTITY CASCADE;
TRUNCATE TABLE fotografer RESTART IDENTITY CASCADE;
TRUNCATE TABLE paket_jasa RESTART IDENTITY CASCADE;
TRUNCATE TABLE booking RESTART IDENTITY CASCADE;
TRUNCATE TABLE pembayaran RESTART IDENTITY CASCADE;
TRUNCATE TABLE review RESTART IDENTITY CASCADE;
TRUNCATE TABLE status_booking RESTART IDENTITY CASCADE;


ALTER TABLE review ADD CONSTRAINT unique_review_booking UNIQUE(id_booking);

ALTER TABLE booking
ALTER COLUMN waktu_mulai TYPE TIME USING waktu_mulai::TIME,
ALTER COLUMN waktu_selesai TYPE TIME USING waktu_selesai::TIME;
