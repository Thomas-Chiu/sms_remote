const receiver = () => {
  // const bodyParser = require("body-parser");
  const express = require("express");
  const cors = require("cors");
  const app = express();
  const port = 3000;
  const replyItem = {};
  const replyArr = [];
  const taxId = "13091876";

  // 處理 HTTP request
  app.use(express.json());
  app.use(express.urlencoded({ extended: true }));
  app.use(
    cors({
      origin: false,
      allowedHeaders: ["Content-Type', 'Authorization"],
    })
  );

  // 前端靜態資源
  app.use("/", express.static("public"));

  // 後端處理邏輯
  app.get("/receiver", (req, res) => {
    if (Object.keys(req.query).length === 0) {
      res.status(403).send({ success: false, message: "無權限" });
      return;
    }
    console.log("系統回報", req.query);
    res.status(200).send({ success: true, message: "OK" });
    replyItem["BatchID"] = req.query.BatchID;
    replyItem["ReceiverMobile"] = decodeURIComponent(req.query.RM);
    replyItem["ReplyTime"] = req.query.RT;
    replyItem["Stauts"] = req.query.STATUS;
    replyItem["Content"] = decodeURIComponent(req.query.SM);
    replyItem["MsgRecordNo"] = req.query.MR;
    replyItem["UserAccount"] = req.query.USERID;
    replyArr.push(replyItem);
  });

  app.get("/replier/:taxId", (req, res) => {
    if (req.params.taxId !== taxId) {
      res.status(403).send({ success: false, message: "無權限" });
      return;
    }
    // 送出後從陣列移除
    res.status(200).send({ success: true, result: replyArr[0] });
    replyArr.shift();
  });

  app.listen(port, () => {
    console.log(`web 伺服器 http://localhost:${port}`);
  });
};

module.exports = receiver;
