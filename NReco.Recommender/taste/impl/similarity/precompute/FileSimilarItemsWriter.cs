 /// Licensed to the Apache Software Foundation (ASF) under one or more
 /// contributor license agreements.  See the NOTICE file distributed with
 /// this work for additional information regarding copyright ownership.
 /// The ASF licenses this file to You under the Apache License, Version 2.0
 /// (the "License"); you may not use this file except in compliance with
 /// the License.  You may obtain a copy of the License at
 ///
 ///     http://www.apache.org/licenses/LICENSE-2.0
 ///
 /// Unless required by applicable law or agreed to in writing, software
 /// distributed under the License is distributed on an "AS IS" BASIS,
 /// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 /// See the License for the specific language governing permissions and
 /// limitations under the License.


using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using com.google.common.base;
using com.google.common.io;
using org.apache.mahout.cf.taste.similarity.precompute;

namespace org.apache.mahout.cf.taste.impl.similarity.precompute {

 /// Persist the precomputed item similarities to a file that can later be used
 /// by a {@link org.apache.mahout.cf.taste.impl.similarity.file.FileItemSimilarity}
public class FileSimilarItemsWriter : SimilarItemsWriter {

  private File file;
  private BufferedWriter writer;

  public FileSimilarItemsWriter(File file) {
    this.file = file;
  }

  public void open() {
    writer = new BufferedWriter(new StreamWriter(new FileStream(file), Charsets.UTF_8));
  }

  public void add(SimilarItems similarItems) {
    String itemID = String.valueOf(similarItems.getItemID());
    for (SimilarItem similarItem : similarItems.getSimilarItems()) {
      writer.write(itemID);
      writer.write(',');
      writer.write(String.valueOf(similarItem.getItemID()));
      writer.write(',');
      writer.write(String.valueOf(similarItem.getSimilarity()));
      writer.newLine();
    }
  }

  public void close() {
    Closeables.close(writer, false);
  }
}

}