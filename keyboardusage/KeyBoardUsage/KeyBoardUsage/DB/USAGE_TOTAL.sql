/*
Navicat SQLite Data Transfer

Source Server         : Usage
Source Server Version : 20817
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 20817
File Encoding         : 65001

Date: 2016-04-14 15:01:02
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for USAGE_TOTAL
-- ----------------------------
DROP TABLE "main"."USAGE_TOTAL";
CREATE TABLE "USAGE_TOTAL" (
"name"  TEXT,
"id"  INTEGER NOT NULL,
"count"  INTEGER DEFAULT 0,
PRIMARY KEY ("id")
);

-- ----------------------------
-- Records of USAGE_TOTAL
-- ----------------------------
INSERT INTO "USAGE_TOTAL" VALUES ('TOTAL', 1, 1);
INSERT INTO "USAGE_TOTAL" VALUES ('MAIN', 2, 0);
INSERT INTO "USAGE_TOTAL" VALUES ('NUMBER', 3, 0);
INSERT INTO "USAGE_TOTAL" VALUES ('FUNC', 4, 0);
INSERT INTO "USAGE_TOTAL" VALUES ('CTRL', 5, 0);
